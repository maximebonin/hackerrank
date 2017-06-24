#include <iostream>
#include <vector>
#include <string>
using namespace std;

void otherMoves(int PrincessVertical, int PrincessHorizontal, int BotVertical, int BotHorizontal){
  if (PrincessVertical < BotVertical){
      BotVertical--;
      cout << "UP" << endl;
  }else if (PrincessVertical > BotVertical){
      BotVertical++;
      cout << "DOWN" << endl;
  }else if (PrincessHorizontal < BotHorizontal){
      BotHorizontal--;
      cout << "LEFT" << endl;
  }else if (PrincessHorizontal > BotHorizontal){
      BotHorizontal++;
      cout << "RIGHT" << endl;
  }

  while ((BotVertical != PrincessVertical) && (BotHorizontal != PrincessHorizontal)){
      otherMoves(PrincessVertical, PrincessHorizontal, BotVertical, BotHorizontal);
  }    
}

void nextMove(int n, int r, int c, vector <string> grid){

  int vertical = 0;
  int horizontal = 0;

  //  f... Big O for this one ; i'm tired
  //  
  for(int i=0; i < n; i++){
      string inspectedString = grid[i];
    for(int j=0; j < n; j++){
        if( inspectedString[j] == 'p'){
            vertical = i;
            horizontal = j;
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

  if ((r != vertical) && (c != horizontal)){
      otherMoves(vertical, horizontal, r, c);
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
