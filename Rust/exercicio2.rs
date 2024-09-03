use std::io;

fn fill_array(array: &mut [i32], number: i32) {
    for i in 0..array.len() {
        array[i] = number * i as i32;
    }
}


fn main() {
    let mut array = [0; 10];

    fill_array(&mut array, 5);
    for i in 0..array.len() {
        println!("{}", array[i]);
    }
}