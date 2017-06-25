#include <iostream>
#include <vector>
#include <string>
using namespace std;


void nextMove(int n, int r, int c, vector <string> grid){

  int vertical = 0;
  int horizontal = 0;

  bool found = false;
    
  for(int i =0; i < n; i++){
      
      string line = grid[i];
      for(int j = 0; j < n; j++){
          if( line[j] == 'p' ){
            vertical = i;
            horizontal = j;
            found = true;
            break;
          }
          if (found){
          break;
      	  }
      }
  }
    
  if (vertical < r){
      r--;
      cout << "UP" << endl;
  }else if (vertical > r){
      r++;
      cout << "DOWN" << endl;
  }else if (horizontal < c){
      c--;
      cout << "LEFT" << endl;
  }else if (horizontal > c){
      c++;
      cout << "RIGHT" << endl;
  }
}
int main(void) {

    int n, r, c;
    vector <string> grid;

    cin >> n;
    cin >> r;
    cin >> c;

    for(int i=0; i<n; i++) {
        string s; cin >> s;
        grid.push_back(s);
    }

    nextMove(n, r, c, grid);
    return 0;
}
