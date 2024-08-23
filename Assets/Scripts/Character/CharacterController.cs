
public class CharacterController  : ICharacterController
{

    private readonly ICharacterModel _model;
    private readonly CharacterView _view;

    public CharacterController(ICharacterModel model, CharacterView view)
    {
        _model = model;
        _view = view;
    }

    // set item 
        // remove item 

    // get item stats 
}
