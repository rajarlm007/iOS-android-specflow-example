Feature: Add an acquaintance
    As a user I want to add a new acquaintance

Scenario: Add a new acquaintance

   Given I tap on the add acquaintance button
    When I fill in the required fields and tap on the Save button
    Then I should see the new acquaintance in the list

Scenario: Login to Fire App
    Given I login to fire application
