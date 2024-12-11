
document.addEventListener("DOMContentLoaded", () => {
    const errorBox = document.getElementById("error-box");
    const successBox = document.getElementById("success-box");

    function hideBox(boxError){
        if(getComputedStyle(boxError).display == "block" || getComputedStyle(successBox).display == "block"){
            setTimeout(() => {
                boxError.style.setProperty("display","none");
            },2000)
        }
    }

    
    hideBox(errorBox,successBox);
})