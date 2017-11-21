require 'time'
require 'csv'
f = File.open('speedtest.log', 'r')
CSV.open('SpeedTestResults.csv', 'w+') do |c|
  c << ["UnixTime","Date","Download","Upload"]
  f.readlines.each do |file, w|
    lines = file.lines
    lines.each do |line|
      if line.start_with?('Sun','Mon','Tue','Wed','Thu','Fri','Sat')
        @csvline = "#{Time.parse(line.strip).to_time.to_i},#{Time.parse(line.strip).strftime('%Y-%m-%d %H:%M:%S')},"
      elsif line.start_with?('Ping')
        line.next
      elsif line.start_with?('Download')
        @csvline += "#{line[10..14]},"
      elsif line.start_with?('Upload')
        @csvline += "#{line[8..11]}"
      elsif line.start_with?('Cannot')
        @csvline = ""
      elsif line.start_with?(" ")
        c << @csvline.parse_csv unless @csvline.empty?
        @csvline = ""
      end
    end
  end
end