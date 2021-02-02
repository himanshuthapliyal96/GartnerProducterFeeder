# GartnerProducterFeeder

Release notes:

Technical Impact:
	-> All the unit tests are written using NUNIT
	-> CommandLine: <Path to exe>GartnerProductFeeder.exe import <source Eg:capterra> <drive location of source>
	
How to run code / tests?
 1.Open solution <GartnerSolution\GartnerProductFeeder\GartnerProductFeeder.sln> in visual studio.
 2.Set commandline arguments in visual studio, using properties->debug
   eg: import capterra "Drive Location\feed-products\capterra.yaml"
 3.Run to project and open launch link in any browser

 OR
 
 1.Open command prompt
 2.Change drive to the location where GartnerProductFeeder.exe is located
 3.Run command GartnerProductFeeder.exe import <source Eg:capterra> <drive location of source>
 
To Run from web:
1. Configure the AppSettings.json to specify the path of folder where data sources are stored in "ProductsSourcePath"
   eg: ProductsSourcePath": "XXXXX\capterra.yaml"
2. Run the services.
3.Open postman and send a post request
   eg: https://localhost:44328/api/GartnerProduct/capterra
   
Note: Databease conectivity is not implemented as of now.Will be handled as an extention if needed.

Tests
All the tests are written using NUNIT.

If more time was given I would have extended the testcase to ensure other functionalities as well.
This code is just a rough framework to implement the ProductFeeder for Gartner.

GartnerProductFeeder usses Factory pattern so that If new source is added then it is easy to extend the logic.
DbConnect usses IOC so that in future If Mongo comes into picture the only places where dependencis are initaialized neesds to be changed.
Custom exception handler can be implemented and added as a middleware.

GIT:https://github.com/himanshuthapliyal96/GartnerProducterFeeder
