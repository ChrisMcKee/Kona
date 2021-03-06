When /^I visit the homepage$/ do
  visit url + '/'
end

When /^I visit "([^\"]*)"$/ do |category|
  When "I visit the homepage"
  click_link category
end

When /^I visit the "([^\"]*)" details page$/ do |product_name|
  product = Product.find_by_ProductName product_name
  visit "#{url}/Product/Details/#{product.SKU}" 
end
