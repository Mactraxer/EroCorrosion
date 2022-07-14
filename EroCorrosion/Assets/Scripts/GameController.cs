using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private Player _player;
    [SerializeField] private List<Block> _blocks;
    [SerializeField] private InfoPanel _info;

    private void Start()
    {
        _inputManager.OnInputHorizontalAxis += OnInputHorizontalAxis;
        _inputManager.OnInputDig += OnInputDigHandler;
        _inputManager.OnInputJump += OnInputJumpHandler;

        foreach (var item in _blocks)
        {
            item.OnBlockBroken += OnBlockBrokenHandler;
        }
    }


    private void OnDisable()
    {
        _inputManager.OnInputHorizontalAxis -= OnInputHorizontalAxis;
        _inputManager.OnInputDig -= OnInputDigHandler;
        _inputManager.OnInputJump -= OnInputJumpHandler;
    }
    private void OnBlockBrokenHandler(Block block)
    {
        _player.ApplyBlockReward(block.Reward, block.Resource);
        block.OnBlockBroken -= OnBlockBrokenHandler;
        Destroy(block.gameObject);
    }

    private void OnInputJumpHandler()
    {
        _player.Jump();
    }

    private void OnInputDigHandler()
    {
        _player.Dig();
    }

    private void OnInputHorizontalAxis(float value)
    {
        _player.Move(value);
    }
}