

class LinkedList{

    val;
    next;
    constructor(val = 0){
        this.val = val;
        this.next = null;
    }
}

function load(arr = []){
    var node = null;

    for(var i = arr.length - 1; i >= 0; i--){

        var dummy = new LinkedList(arr[i]);
        dummy.next = node;
        node = dummy;

    }

    return node;
}

var arr = [4,3,2,1]1


var node = load(arr);

while(node != null){

    console.log(node.val);

    node = node.next;
}