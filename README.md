# Appy Christmas

[![Build status](https://ci.appveyor.com/api/projects/status/uw7tk2r317see61a/branch/master?svg=true)](https://ci.appveyor.com/project/rh072005/appy-christmas/branch/master)

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
 * `http://localhost:5000/api/products/{x}/` - this will return the product with the id of x (zero based remember!)
 * `http://localhost:5000/swagger/ui/index.html`  - a swagger ui page allowing you to test the api.

**You will probably need to install the [ASP.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core) to be able to run this.**

The product list is just hard coded into the `getProducts()` method  
If you want something that is DB backed then try the entityframework branch

The public URL for this API is http://appychristmas.azurewebsites.net/api/products/ with the swagger endpoint available here http://appychristmas.azurewebsites.net/swagger/ui/index.html

## The Technologies
### Cross Platform 
 - Ionic
 - Xamarin
 - Cordova
 
### Platform Specific
 - UWP

### WebApp Based
 - Angular
 - DOJO

### Less Interesting
 - iOS
 - Android
 - jQuery Mobile
 
## License
MIT © [Richard Cooper](https://richardcooper.mit-license.org/)