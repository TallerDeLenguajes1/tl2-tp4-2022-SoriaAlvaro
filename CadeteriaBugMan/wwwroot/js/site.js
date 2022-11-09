const d = document;
let down = "▼",
up = "▲";
const toggleList = (panel) =>{
    const allPanel = d.querySelectorAll(panel);
    allPanel.forEach(p => {
        p.addEventListener("click", e => {
            const padre = e.target.parentNode;
            if(e.target.matches(panel)){
                padre.children[1].classList.toggle("open-panel--info");
                if(p.children[1].textContent == down){
                    p.children[1].textContent = up;
                }else {
                    p.children[1].textContent = down;
                }
            }
        });
    });
}
d.addEventListener("DOMContentLoaded", e => {
    toggleList(".panel");
});


