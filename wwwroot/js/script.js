
document.addEventListener("DOMContentLoaded", () => {
    const errorBox = document.getElementById("error-box");

    function hideBox(boxError){
        if(getComputedStyle(boxError).display == "block"){
            setTimeout(() => {
                boxError.style.setProperty("display","none");
            },2000)
        }
    }

    
    hideBox(errorBox);
})