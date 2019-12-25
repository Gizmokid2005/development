require 'nokogiri'

doc = Nokogiri::XML(File.open("subscription_manager.xml"))

doc.xpath("//outline//outline").each do |sub|

  puts "#{sub['title']}: #{sub['xmlUrl']}"

end