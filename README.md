# Appy Christmas

Mobile App Development Challange 

1. Fork this repository and clone a local copy
2. Run `cake.cmd` to build and start the backend api 
3. Pick one of the technologies from below
4. Write a simple app that calls the backend api and displays the information sent back - it should contain the following pages:
  * Branded "Loading" page
  * Product List page
  * Product detail page
5. Work out how to test the app
6. Write up the learnings, pros\cons, license costs etc.

There are included assets to get you started but you can supplement these if you wish.

## The Backend API
Running `cake` from the commandline will build and spin up a simple aspnet core api with the following endpoints
 * `http://localhost:5000/api/products/` - this will return a list of products
 * `http://localhost:5000/api/products/{id}/` - this will return the product with the id of x
 * `http://localhost:5000/swagger/ui/index.html`  - a swagger ui page allowing you to test the api.

The product list is just hard coded into the `getProducts()` method  
If you want something that is DB backed then try the entityframework branch

## The Technologies
### Cross Platform 
 - Ionic
 - Xamarin
 - Cordova
 
### Platform Specific
 - iOS
 - Android
 - UWP

### WebApp Based
 - Angular
 - jQeury Mobile
 - DOJO