Feature: Survey
  As a consumer of the API
  I want to get a list of surveys
  So that I can lst them on the screen

Scenario: Get list of surveys  
    Given I am an authenticated user  
    When I request the list of surveys  
    Then I should receive a list of surveys  
    And the list should contain survey details  

