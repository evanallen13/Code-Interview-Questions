

var bubbleSort = function(arr){

    var isSorted = false
    while(!isSorted){
        isSorted = true;

        for(var i = 0; i < arr.length - 1; i++){
            var curr = arr[i];
            var next = arr[i + 1];

            if(curr > next){
                arr[i] = next;
                arr[i + 1] = curr;
                isSorted  = false;
            }
        }
    }
}


var arr = [];


for(var i = 0; i < 5; i++){
    var int = Math.floor(Math.random() * Math.floor(100));
    arr.push(int);
}

bubbleSort(arr);