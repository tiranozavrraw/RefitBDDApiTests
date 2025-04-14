Feature: Cruises
  
  Scenario: Get cruises with destination “Caribbean” and sort them by number of crew
    
    Given Cruise with Destination Caribbean and DestinationId 147237
    When Search for cruises with DestinationId 147237 and Order popularity
    Then the result should contain cruises