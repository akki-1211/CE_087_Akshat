/*var connection = new signalR.HubConnectionBuilder().withUrl("/Chat").build();

//Disable send button until connection is established  
document.getElementById("sendBtn").disabled = true;

connection.on("ReceiveMessage", function (userid, message) {
    var msg = message.replace(/&/g, "&").replace(/</g, "<").replace(/>/g, ">");
    var encodedMsg = msg;
    if (userid == @ViewBag.receiverId) {
    var incoming = document.createElement("div");
    var receivemsg = document.createElement("div");
    var receivedwithmsg = document.createElement("div");
    var date = document.createElement("span");
    date.classList.add("time_date");
    date.textContent = Date.now;
    var msg = document.createElement("p");
    msg.textContent = encodedMsg;
    incoming.classList.add("incoming_msg");
    receivemsg.classList.add("received_msg");
    receivedwithmsg.classList.add("received_withd_msg");
    receivedwithmsg.appendChild(msg);
    receivedwithmsg.appendChild(date);
    receivemsg.appendChild(receivedwithmsg);
    incoming.appendChild(receivemsg);
    document.getElementById("msg").appendChild(incoming);
}
    else {
    var outgoing = document.createElement("div");
    var sentmsg = document.createElement("div");
    var date = document.createElement("span");
    date.textContent = Date.now;
    date.classList.add("time_date");
    var msg = document.createElement("p");
    msg.textContent = encodedMsg;
    sentmsg.classList.add("sent_msg");
    outgoing.classList.add("outgoing_msg");
    sentmsg.appendChild(msg);
    sentmsg.appendChild(date);
    outgoing.appendChild(sentmsg);
    document.getElementById("msg").appendChild(outgoing);
}
var li = document.createElement("li");
li.textContent = encodedMsg;
document.getElementById("ulmessages").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (message, @ViewBag.receiverId) {
    var message = document.getElementById("txtmessage").value;
    var id = @ViewBag.receiverId;
    connection.invoke("SendMessage", message, id).catch(function (err) {
        return console.error(err);
    });
    event.preventDefault();
})*/;