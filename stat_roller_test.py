from random import randint
from datetime import datetime as dt


MIN_SCORE = 63

def strength_roll() -> int:
    """
    Rolls strength stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    strength = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        strength.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    strength.sort()
    temp_list = [*strength]
    strength.pop(0)
    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Strength Rolls = {temp_list}: {sum(strength)}\n")

    return sum(strength)


def dexterity_roll() -> int:
    """
    Rolls dexterity stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    dexterity = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        dexterity.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    dexterity.sort()
    temp_list = [*dexterity]
    dexterity.pop(0)

    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Dexterity Rolls = {temp_list}: {sum(dexterity)}\n")

    return sum(dexterity)


def constitution_roll() -> int:
    """
    Rolls constitution stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    constitution = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        constitution.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    constitution.sort()
    temp_list = [*constitution]
    constitution.pop(0)

    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Constitution Rolls = {temp_list}: {sum(constitution)}\n")

    return sum(constitution)


def intelligence_roll() -> int:
    """
    Rolls intelligence stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    intelligence = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        intelligence.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    intelligence.sort()
    temp_list = [*intelligence]
    intelligence.pop(0)

    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Intelligence Rolls = {temp_list}: {sum(intelligence)}\n")

    return sum(intelligence)


def wisdom_roll() -> int:
    """
    Rolls wisdom stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    wisdom = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        wisdom.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    wisdom.sort()
    temp_list = [*wisdom]
    wisdom.pop(0)

    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Wisdom Rolls = {temp_list}: {sum(wisdom)}\n")

    return sum(wisdom)


def charisma_roll() -> int:
    """
    Rolls charisma stat

    Args:
        time (str): current date and time
        roll_set (int): # of attempts

    Returns:
        int: sum of the remaining dice rolled
    """
    charisma = []
    temp_list = []

    # Rolls 4, 6-sided dice
    for _ in range(4):
        charisma.append(randint(1,6))

    # Sorts, creates temp list, removes lowest value
    charisma.sort()
    temp_list = [*charisma]
    charisma.pop(0)

    # Writes outputs to file
    with open("log.txt", "a") as f:
        f.write(f"Charisma Rolls = {temp_list}: {sum(charisma)}\n")

    return sum(charisma)


def main(roll_set = 1) -> dict:
    ability_scores = dict(strength = 0, dexterity = 0, constitution = 0, intelligence = 0,  wisdom = 0, charisma = 0)
    current_time = dt.now()
    time = current_time.strftime("%B %d, %Y %H:%M:%S")
    
    with open("log.txt", "a") as f:
        f.write(f"{time} Attempt {roll_set}\n\n")


    # Rolls strength ability
    ability_scores['strength'] = strength_roll()

    # Rolls dexterity ability
    ability_scores['dexterity'] = dexterity_roll()

    # Rolls constitution ability
    ability_scores['constitution'] = constitution_roll()

    # Rolls intelligence ability
    ability_scores['intelligence'] = intelligence_roll()

    # Rolls wisdom ability
    ability_scores['wisdom'] = wisdom_roll()

    # Rolls charisma ability
    ability_scores['charisma'] = charisma_roll()

    if sum(ability_scores.values()) < MIN_SCORE:
        return main(roll_set + 1)
    else:
        with open("log.txt", "a") as f:
            f.write("========================\n\n")
        return ability_scores
    
main()
    








