
let rover = localStorage.getItem("rover");
let getDate = document.getElementById("user-date");
const ButtonDate = document.getElementById("date-submit");
const imagesDiv = document.getElementById("imagesdiv");







const GetRoverInfo = async () => {
    const response = await fetch("api/Drones/"+rover);
    const data = await response.json();
    return data ;
}

const GetRoverImages = async (userDate) => {
    const name = await GetRoverInfo();
    const response = await fetch("https://api.nasa.gov/mars-photos/api/v1/rovers/"+name.droneName+"/photos?earth_date="+userDate+"&api_key=ZGfE6ptVy6zaqHXdEoUloYJpd1UIqENbaRKpPRoV");
    const data = await response.json();
    return data;
}


ButtonDate.addEventListener("click", ()=>{
    GetRoverImages(getDate.value);
    displayImages();
    
});

const displayImages = async() =>{
    const getImages = await GetRoverImages(getDate.value);
    
    imagesDiv.innerHTML = "";
    for(i = 0 ; i< getImages.photos.length ; i++){
        const infoDiv = document.createElement("div");
        infoDiv.id = "info-div";
        const img = document.createElement("img");
        const imageDiv = document.createElement("div");
        imageDiv.id = "imageDiv";
        const spanForCameraName = document.createElement("span");
        const spanForDate = document.createElement("span");
        const spanForRoverName = document.createElement("span");
      
        img.src = getImages.photos[i].img_src;
        spanForCameraName.innerHTML = " Camera: " + getImages.photos[i].camera.name;
        spanForDate.innerHTML = " Date:" + getImages.photos[i].earth_date + "&nbsp;&nbsp;";
        spanForRoverName.innerHTML = "Rover: " + getImages.photos[i].rover.name + "&nbsp;&nbsp;";
        infoDiv.append(spanForRoverName,spanForDate,spanForCameraName);
        imageDiv.append(img,infoDiv);
        imagesDiv.append(imageDiv);
    }
}


