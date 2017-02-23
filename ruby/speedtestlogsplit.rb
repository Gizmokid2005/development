require 'time'
require 'csv'
f = File.open('speedtest.log', 'r')
CSV.open('SpeedTestResults.csv', 'w+') do |c|
  c << ["UnixTime","Date","Download","Upload"]
  f.readlines.each_slice(5) do |l|
    c << [Time.parse(l[0].strip).to_time.to_i, Time.parse(l[0].strip).strftime('%Y-%m-%d %H:%M:%S'), l[2][10..14], l[3][8..11]]
  end
end