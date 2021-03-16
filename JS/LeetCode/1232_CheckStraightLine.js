

var checkStraightLine = function(coordinates) {
    
    if(coordinates.length == 0 || coordinates.length == 1) return true;
    
    var M = 0;
    for(var i = 0; i < coordinates.length - 1; i++){
        
        x1 = coordinates[i][0];
        y1 = coordinates[i][1];
        
        x2 = coordinates[i + 1][0];
        y2 = coordinates[i + 1][1];

        /// Check if Divided by 0
        if(x2 - x1 === 0)
            m = (y2 - y1) + .000001 / (x2 - x1) + .000001;
        else
            m = (y2 - y1) / (x2 - x1);
     
        //// Check if M is Populated
        if(i === 0)
            M = m;

        // Return False 
        if(m != M) return false;

    }

    return true;
};


var coordinates = [[0,0],[0,1],[0,-1]];

console.log(checkStraightLine(coordinates)); 