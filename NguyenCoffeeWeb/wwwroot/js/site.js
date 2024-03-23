$(() => {
    //    LoadPostData();

    var connection = new signalR.HubConnectionBuilder().withUrl("/signalrServer").build();
    connection.start();

    connection.on("LoadAccount", function () {
        //        LoadPostData();
        alert("Accounts loaded successfully!");
        location.href = '/Admin/Accounts';
    })
})