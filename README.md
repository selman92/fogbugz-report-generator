## FogBugz Report Generator

Generates weekly HTML reports using Manuscript (previously FogBugz) API.

All cases are listed in the following format:

`#Case Id - Case Title`

For example:

`#2415 - Intro Case for Jack`

Currently two types of report are supported:

-**This Week**: Lists all the cases that are assigned to the user in the current week's milestone.

-**Last Week**: Lists all the cases that the user has logged time in, in the previous week.

A Manuscript API token is needed to use the program. You can follow the steps listed [here](http://help.fogcreek.com/12252/manuscript-api-token) to get a new token.

Cases can be excluded based on their title. You must enter excluded words in a comma separated format. The words are **case-insensitive**. All cases that contains any of the entered words will be excluded in the generated report.

