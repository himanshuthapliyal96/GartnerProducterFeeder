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

Tests
All the tests are written using NUNIT.

If more time was given I would have extended the testcase to ensure other functionalities as well.
This code is just a rough framework to implement the ProductFeeder for Gartner.

GartnerProductFeeder usses Factory pattern so that If new source is added then it is easy to extend the logic.
DbConnect usses IOC so that in future If Mongo comes into picture the only places where dependencis are initaialized neesds to be changed.

GIT:https://github.com/himanshuthapliyal96/GartnerProducterFeeder
