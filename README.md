# Tracy Developer Meetup Unity with Realm Example

A getting started example from the [Tracy Developer Meetup](https://www.tracydevs.com/2022/08/game-development-unity-mongodb-realm/) for creating a 2D Unity game that leverages MongoDB Atlas and Realm for storing data and syncing it between the gaming device and the cloud.

## Instructions

You need to do more than cloning the project to getting it working in your own development environment because of the use of MongoDB Device Sync.

The following should put you on the correct path to success:

1. Create a MongoDB Atlas account and deploy a free M0 sized cluster.
2. Create a database in the cluster and a collection for the synced data.
3. Create a new application in the MongoDB App Services.
4. Configure a schema for the application.
5. Enable anonymous authentication for the application.
6. Enable device sync for the application.
7. Copy the MongoDB application ID and add it within the Unity project.

Drop me a message on [Twitter](https://www.twitter.com/nraboy) if you get stuck, or find me at the next [Tracy Developer Meetup](https://www.tracydevs.com).