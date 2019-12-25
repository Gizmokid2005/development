  # Find all the files in the current directory
  Dir.glob("*.sii") do |file|
    text = File.read(file)
    oldmass = text.match(/mass: (.+)/)[1]
    newmass = (text.match(/mass: (.+)/)[1].to_f * 2).to_s
    replacemass = text.gsub!(oldmass,newmass)
    oldrewd = text.match(/unit_reward_per_km: (.+)/)[1]
    newrewd = (text.match(/unit_reward_per_km: (.+)/)[1].to_f * 1.5).to_s
    replacerewd = replacemass.gsub!(oldrewd,newrewd)
    File.open(file, "w") {|f| f.puts replacerewd}
    puts "Filename is #{file}: MASS was changed from #{oldmass} TO #{newmass} || REWARD was changed from #{oldrewd} TO #{newrewd}"
  end