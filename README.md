# Passenger
# Onion architecture
  -> It provides better maintainability as all the codes depend on layers or the center.
     It provides better testabilty as the unit test can be created for separate layers without an effect of other modules of the application.
     It develops a loosely coupled application as the outer layer of the application always communicates with inner layer via interfaces.
     Any concrete implantation would be provided to the application at run time
     Domain entities are core and center part. It can have access to both database and UI layers.
     The internal layers never depend on external layer. The code that may have changed should be part of an external layer.
# Domain Driven Development
  -> It is a development approach that deeply values the domain model and connects it to the implementation. DDD was coined and initially developed by Eric Evans.
# Implementation of Command Query Separation
  -> Functions that change state should not return values and functions that return values should not change state.