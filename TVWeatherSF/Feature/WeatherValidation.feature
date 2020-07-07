Feature: WeatherValidation
	This feature validates weather from multiple sources for a city

@mytag
Scenario: Compare weather forcast from multiple sources of a metro city
	Given I read weatherForcast from ndtv weather website of an metro city
	When I read weatherforcast of of op	enWeather API of metro city
	Then I validate the weatherforcast from both the sources

	
