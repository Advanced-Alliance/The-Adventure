"use strict";

let userConfig = {
    viewport: {
        size: {
            x: 1024,
            y: 1024
        }
    },
    map: {
        size: {
            x: 32,
            y: 32
        }
    },
    squareSize: 32,
    username: 'Alpha'
}

document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("adblockWarningMessage").remove();
    createMap();
    applySettings();
    
});

function createMap() {
    const viewport = document.getElementById("viewport");
    //генерация строк
    for (let i = 0; i < userConfig.map.size.y; i++) {
        let row = document.createElement("div");
        row.setAttribute("class", "row");
        //генерация столбцов
        for (let j = 0; j < userConfig.map.size.x; j++) {
            let cell = document.createElement("div");
            cell.setAttribute("class", "cell");
            row.appendChild(cell);
        }
        viewport.appendChild(row);
    }
};
function applySettings() {
    //document.styleSheets[1].insertRule(".cell {width: " + userConfig.squareSize + "px; height: " + userConfig.squareSize + "px;}", 0);

    let cells = document.getElementsByClassName("cell");
    for (let cell of cells) {
        cell.style.width = "32px";
        cell.style.height = "32px";
    };
};