# Find all the files in the current directory
Dir.glob("*.sii") do |file|
  text = File.read(file)
  if file.match(/dlc_oversize_cargo/)
    @massmult = 2
    @rewdmult = 1.5
  elsif file.match(/dlc_heavy_cargo/)
    @massmult = 2
    @rewdmult = 2
  elsif file.match(/dlc_forest_harvesting/)
    @massmult = 2
    @rewdmult = 1.5
  else
    @massmult = 2
    @rewdmult = 1.5
  end
  oldmass = text.match(/mass: (.+)/)[1]
  newmass = (text.match(/mass: (.+)/)[1].to_f * @massmult).round(3).to_s
  replacemass = text.gsub!(oldmass,newmass)
  oldrewd = text.match(/unit_reward_per_km: (.+)/)[1]
  newrewd = (text.match(/unit_reward_per_km: (.+)/)[1].to_f * @rewdmult).round(4).to_s
  replacerewd = replacemass.gsub!(oldrewd,newrewd)
  File.open(file, "w") {|f| f.puts replacerewd}
  puts "Filename is #{file}: MASS was changed from #{oldmass} TO #{newmass} || REWARD was changed from #{oldrewd} TO #{newrewd}"
end