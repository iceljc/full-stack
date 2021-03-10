function queue() {
	this.length = 0;
	let queueItems = [];

	this.pushItem = function (item) {
		queueItems.push(item);
		this.length++;
	}

	this.popItem = function () {
		if (this.length > 0) {
			queueItems.shift();
			this.length--;
		} else {
			console.log("The queue is empty");
		}

	}

	this.frontItem = function () {
		if (this.length > 0) {
			console.log(queueItems[0]);
		} else {
			console.log("The queue is empty");
		}

	}

	this.printQueue = function () {
		console.log(queueItems);
	}


}


q = new queue()
q.pushItem("a");
q.pushItem("b");
q.pushItem("c");
q.pushItem("d");
q.pushItem("e");
q.printQueue();

q.frontItem();

console.log('Pop an item from queue...')
q.popItem();
q.frontItem();

q.printQueue();








