![Rock RMS](https://raw.githubusercontent.com/SparkDevNetwork/Rock/develop/Images/github-banner.png)

Rock RMS is an open source Relationship Management System (RMS) and Application
Framework for 501c3 organizations[^1]. While Rock specializes in serving the unique needs of churches it's
useful in a wide range of service industries.  Rock is an ASP.NET 4.5 C# web application
that uses Entity Framework 6.0, jQuery, Bootstrap 3, and many other open source libraries.

Our main developer starting point site is [the wiki](https://github.com/SparkDevNetwork/Rock/wiki).

## Learn More

Jump over to our [Rock website](https://www.rockrms.com/) to find out more. Keep up to date by:

* [Reading our blog](https://community.rockrms.com/connect)
* [Following us on Twitter](https://www.twitter.com/therockrms)
* [Liking us on Facebook](https://www.facebook.com/therockrms)
* [Reading the community Q & A](https://community.rockrms.com/ask)
* [Subscribing to our newsletter](https://www.rockrms.com/Rock/Subscribe)

## License
Rock released under the [Rock Community License](https://www.rockrms.com/license).

## Crafted By

A community of developers led by the [Spark Development Network](https://www.sparkdevnetwork.com/).

## Installer Note

Normally the [Rock installer](https://www.rockrms.com/Download) generates a unique `PasswordKey`
`DataEncryptionKey` and MachineKey's `validationKey` and `decryptionKey`. So if you decide
to clone the repo and run it directly, you will need to handle that aspect yourself.

 [^1]: [See our FAQ for details on our license](https://www.rockrms.com/faq)

## Notes about my additions 

  * I encountered a bug on the login screen that prevented logins from working. I had to add the LegacyLogin block from an older version of the soure code to enable the login screen to work. This repository has included this file to resolve this issue.  
  * As of now, the pages for Small Groups aren't currently created by default on a brand new install, these still need to be created in the UI. Ideally these would be created by default, but the blocks are present and can be used in new pages. I'd like to try to see how to implement getting these added by default, ideally that would make it a lot easier for demonstration/testing purposes. 
  * This requires a route to be added to the Small Group Details page titled "SmallGroups/Details". The routes page in the admin settings does not work (it has a bug and generates a blank page for the user, which I intend to look into separately), so my initial contribution used a workaround to link the pages together. However, I then realized I had been completely overthinking the problem and that routes could easily just be added on the page settings itself. I have corrected this and pushed a new commit that implements this properly. It will work as soon as the route is added in the Details page settings. 
  
  P.S.  It was a pleasure getting to learn the codebase and reading through the different guides. Your documentation is very intuitive and easy to follow. Whoever wrote your documentation deserves multiple high-fives and an endless supply of Starbucks.