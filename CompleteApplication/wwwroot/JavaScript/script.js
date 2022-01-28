const getMainContainer = document.getElementById("home-container");
let rover = "";

const GetMyData = async () => {
    const response = await fetch("/api/Drones");
    const data = await response.json();
    return data;
}


const GetDronesList = async() => {

    const data = await GetMyData();
  
    for (i = 0; i < data.length; i++) {
        let drone = data[i];
        const id = drone.droneId;
        const name = drone.droneName;
        const DroneDiv = document.createElement("div");
        DroneDiv.id = "drone-div";
        const DroneSpanName = document.createElement("span");
        DroneSpanName.id = "drone-span-name";
        const DivForImage = document.createElement("div");
        DivForImage.id = "div-for-image";
        const DroneImage = document.createElement("img");
        DroneImage.id = "drone-image";
        const DroneDivButtons = document.createElement("div");
        DroneDivButtons.id = "drone-div-buttons";
        const DroneButtonGetImages = document.createElement("button");
        DroneButtonGetImages.id = "drone-span-get-images";
        const DroneButtonGetInfo = document.createElement("button");
        DroneButtonGetInfo.id = "drone-span-get-info";
        DroneSpanName.innerHTML = `${data[i].droneName}`;
        DroneImage.src = `${data[i].droneImage}`;

        DroneButtonGetImages.innerHTML = "Get Images";
        DroneButtonGetImages.addEventListener("click", () => {
            localStorage.clear();
            let rover = id;
            location.href = "images.html";
            localStorage.setItem("rover", rover)
        });

        DroneButtonGetInfo.innerHTML = "Get Info";
        DroneButtonGetInfo.addEventListener("click", () => {
            localStorage.clear();
            let rover = name;
            location.href = "info.html";
            localStorage.setItem("rover", rover)
        });

        DivForImage.append(DroneImage);
        DroneDivButtons.append(DroneButtonGetImages, DroneButtonGetInfo);
        DroneDiv.append(DroneSpanName, DivForImage, DroneDivButtons);
        getMainContainer.append(DroneDiv);

     




    }
};

GetDronesList();
console.log(GetMyData());