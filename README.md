<h1>Local Chat Server Application 💬</h1>

<p>This repository contains a Windows Forms application developed in .NET that uses sockets to set up a local chat server. The application allows multiple clients to connect simultaneously and exchange messages through a user-friendly chat interface.</p>

<h2>Overview</h2>

<p>The Local Chat Server Application is designed to enable real-time communication between multiple clients over a local network. The server listens for incoming connections, manages client sessions, and facilitates the exchange of messages. The chat interface provides users with an intuitive environment to send and receive messages.</p>

<h2>Features</h2>

<ul>
  <li><strong>Socket-Based Server:</strong> The application utilizes sockets to establish a local server that can handle multiple client connections simultaneously.</li>
  <li><strong>Multi-Client Support:</strong> Multiple clients can connect to the server at the same time, allowing for group chat functionality.</li>
  <li><strong>Real-Time Messaging:</strong> Clients can send and receive messages in real-time, with messages being broadcasted to all connected clients.</li>
  <li><strong>User-Friendly Interface:</strong> The application includes a simple and intuitive chat interface that allows users to easily participate in conversations.</li>
  <li><strong>Connection Management:</strong> The server handles the connection and disconnection of clients, ensuring a smooth chat experience.</li>
</ul>

<h2>Installation</h2>

<ol>
  <li>Clone the repository:</li>
  <pre><code>git clone https://github.com/AndreaCCarrera/ChatACeniceros.git</code></pre>
  <li>Open the project in your preferred .NET IDE (such as Visual Studio).</li>
  <li>Ensure that you have Windows Forms and the required .NET framework set up in your development environment.</li>
  <li>Build and run the <strong>server</strong> application first to start the local server.</li>
  <li>Then, build and run the <strong>client</strong> application on one or more machines to connect to the server.</li>
</ol>

<h2>Usage</h2>

<ul>
  <li>Start the <strong>server</strong> application to initiate the chat server.</li>
  <li>Launch the <strong>client</strong> application on the same or different machines and connect to the server by entering the server's IP address and port.</li>
  <li>Once connected, use the chat interface to send and receive messages with other connected clients.</li>
</ul>
