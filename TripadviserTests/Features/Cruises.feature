Feature: Cruises
  
  Scenario: Get cruises with destination “Caribbean” and sort them by number of crew
    
    Given Cruise with Destination Caribbean
    When Search for cruises with DestinationId and Order popularity
    Then the result should contain cruises