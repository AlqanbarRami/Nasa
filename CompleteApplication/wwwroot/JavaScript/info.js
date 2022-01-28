let rover = localStorage.getItem("rover");
let fetchUrl = "https://api.nasa.gov/mars-photos/api/v1/manifests/" + rover + "?api_key=ZGfE6ptVy6zaqHXdEoUloYJpd1UIqENbaRKpPRoV";
const getMainContainer = document.getElementById("home-container");
const getMainDiv = document.getElementById("main-div");
const getImageDiv = document.getElementById("image-div");
const getParghraphDiv = document.getElementById("parghraph-div");
const getDetailsDiv = document.getElementById("details-div");



const GetRoverInfoFromNasa = async () => {
    const response = await fetch(fetchUrl);
    const data = await response.json();
    return data;
}

const GetRoverInfoFromMyApi = async () => {
    const response = await fetch("api/Drones/rovers/" + rover);
    const data = await response.json();
    return data;
}
console.log(GetRoverInfoFromNasa());

const ShowRoverInfo = async () => {
    
    const NasaData = await GetRoverInfoFromNasa();
    let NasaInfo = NasaData.photo_manifest;
    const MyApiData = await GetRoverInfoFromMyApi();
    const image = document.createElement("img");
    const parghraph = document.createElement("p");
    const spanName = document.createElement("span");
    const spanLanding = document.createElement("span");
    const spanLaunch = document.createElement("span");
    const spanStatus = document.createElement("span");
    image.src = MyApiData.droneImage;
    parghraph.innerText = MyApiData.droneInfo;
    spanName.innerHTML = "Name : " + MyApiData.droneName +"&emsp;";
    spanLanding.innerHTML = "Landing Date : " + NasaInfo.landing_date + "&emsp;";
    spanLaunch.innerHTML = "Launch Date : " + NasaInfo.launch_date + "&emsp;";
    spanStatus.innerHTML = "Status : " + NasaInfo.status + "&emsp;";
    getImageDiv.append(image);
    getParghraphDiv.append(parghraph);
    getDetailsDiv.append(spanName, spanLanding, spanLaunch, spanStatus);


}

ShowRoverInfo();    

