function Main(A) {
    if (A.length <= 1)
        return true;
    var Monotone;
    (function (Monotone) {
        Monotone[Monotone["Increase"] = 0] = "Increase";
        Monotone[Monotone["Decrease"] = 1] = "Decrease";
        Monotone[Monotone["Equal"] = 2] = "Equal";
    })(Monotone || (Monotone = {}));
    var monotone;
    var currMono;
    for (var i = 1; i <= A.length - 1; i++) {
        var prev = A[i - 1];
        var curr = A[i];
        console.log(monotone);
        if (prev < curr)
            currMono = Monotone.Increase;
        else if (prev > curr)
            currMono = Monotone.Decrease;
        else
            continue;
        if (currMono !== monotone && monotone !== undefined)
            return false;
        monotone = currMono;
    }
    return true;
}
var arr = [2, 2, 2, 1, 4, 5];
var res = Main(arr);
console.log(res);
