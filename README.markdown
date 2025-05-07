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

  * I had to add the LegacyLogin block from an older version of the soure code to enable the login screen to work. This repository has included this file to resolve this issue.  
  * The pages for Small Groups aren't created by default on a brand new install, these still need to be created in the UI. Ideally these would be created by default, but the blocks are present and can be used in new pages.  
  * I discovered an issue with the routes panel in the CMS Admin settings. It is not possible to create routes in the UI due to this bug (the user will see a blank page). I was able to work around it for the purposes of this project, but I did so in a non-ideal way by hardcoding the page ID into the ascx files so that I could still test the details blocks and make sure they worked. This is a terrible solution, I still intend to look at this and see if I can resolve the routes panel issues, that is a bug that probably does need to be fixed (right now it's impossible for the user to add any new routes on admin settings routes panel). 
  
  P.S.  It was a pleasure getting to learn the codebase and reading through the different guides. Your documentation is very intuitive and easy to follow. Whoever wrote your documentation deserves multiple high-fives and an endless supply of Starbucks.