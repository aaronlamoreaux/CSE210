public class Mastery
{
    private List<Reference> _refer = new List<Reference>();
    private List<Scripture> _script = new List<Scripture>();
    private List<Words> _verse = new List<Words>();

    public Mastery()
    {
        _refer.Add(new Reference("1 Nephi", "3", "7"));
        _refer.Add(new Reference("2 Nephi", "2", "25"));
        _refer.Add(new Reference("2 Nephi", "2", "27"));
        _refer.Add(new Reference("2 Nephi", "9", "28", "29"));
        _refer.Add(new Reference("2 Nephi", "25", "23"));
        _refer.Add(new Reference("2 Nephi", "25", "26"));
        _refer.Add(new Reference("2 Nephi", "28", "7", "9"));
        _refer.Add(new Reference("2 Nephi", "31", "19", "20"));
        _refer.Add(new Reference("2 Nephi", "32", "3"));
        _refer.Add(new Reference("2 Nephi", "32", "8", "9"));
        _refer.Add(new Reference("Mosiah", "2", "17"));
        _refer.Add(new Reference("Mosiah", "3", "19"));
        _refer.Add(new Reference("Mosiah", "4", "30"));
        _refer.Add(new Reference("Alma", "7", "11", "13"));
        _refer.Add(new Reference("Alma", "32", "21"));
        _refer.Add(new Reference("Alma", "37", "35"));
        _refer.Add(new Reference("Alma", "39", "9"));
        _refer.Add(new Reference("Alma", "41", "10"));
        _refer.Add(new Reference("Helaman", "5", "12"));
        _refer.Add(new Reference("3 Nephi", "12", "48"));
        _refer.Add(new Reference("3 Nephi", "18", "15"));
        _refer.Add(new Reference("3 Nephi", "18", "20", "21"));
        _refer.Add(new Reference("Ether", "12", "6"));
        _refer.Add(new Reference("Ether", "12", "27"));
        _refer.Add(new Reference("Moroni", "7", "41"));
        _refer.Add(new Reference("Moroni", "7", "45"));
        _refer.Add(new Reference("Moroni", "7", "47", "48"));
        _refer.Add(new Reference("Moroni", "10", "4", "5"));

        _verse.Add(new Words("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        _verse.Add(new Words("Adam fell that men might be; and men are, that they might have joy."));
        _verse.Add(new Words("Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself."));
        _verse.Add(new Words("28 O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish. 29 But to be learned is good if they hearken unto the counsels of God."));
        _verse.Add(new Words("For we labor diligently to write, to persuade our children, and also our brethren, to believe in Christ, and to be reconciled to God; for we know that it is by grace that we are saved, after all we can do."));
        _verse.Add(new Words("And we talk of Christ, we rejoice in Christ, we preach of Christ, we prophesy of Christ, and we write according to our prophecies, that our children may know to what source they may look for a remission of their sins."));
        _verse.Add(new Words("7 Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us. 8 And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God. 9 Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark."));
        _verse.Add(new Words("19 And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save. 20 Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."));
        _verse.Add(new Words("Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do."));
        _verse.Add(new Words("8 And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. 9 But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul."));
        _verse.Add(new Words("And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));
        _verse.Add(new Words("For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father."));
        _verse.Add(new Words("But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not."));
        _verse.Add(new Words("11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people. 12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities. 13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me."));
        _verse.Add(new Words("And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
        _verse.Add(new Words("O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God."));
        _verse.Add(new Words("Now my son, I would that ye should repent and forsake your sins, and go no more after the lusts of your eyes, but cross yourself in all these things; for except ye do this ye can in nowise inherit the kingdom of God. Oh, remember, and take it upon you, and cross yourself in these things."));
        _verse.Add(new Words("Do not suppose, because it has been spoken concerning restoration, that ye shall be restored from sin to happiness. Behold, I say unto you, wickedness never was happiness."));
        _verse.Add(new Words("And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."));
        _verse.Add(new Words("Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect."));
        _verse.Add(new Words("Verily, verily, I say unto you, ye must watch and pray always, lest ye be tempted by the devil, and ye be led away captive by him."));
        _verse.Add(new Words("20 And whatsoever ye shall ask the Father in my name, which is right, believing that ye shall receive, behold it shall be given unto you. 21 Pray in your families unto the Father, always in my name, that your wives and your children may be blessed."));
        _verse.Add(new Words("And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."));
        _verse.Add(new Words("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."));
        _verse.Add(new Words("And what is it that ye shall hope for? Behold I say unto you that ye shall have hope through the atonement of Christ and the power of his resurrection, to be raised unto life eternal, and this because of your faith in him according to the promise."));
        _verse.Add(new Words("And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things."));
        _verse.Add(new Words("47 But charity is the pure love of Christ, and it endureth forever; and whoso is found possessed of it at the last day, it shall be well with him. 48 Wherefore, my beloved brethren, pray unto the Father with all the energy of heart, that ye may be filled with this love, which he hath bestowed upon all who are true followers of his Son, Jesus Christ; that ye may become the sons of God; that when he shall appear we shall be like him, for we shall see him as he is; that we may have this hope; that we may be purified even as he is pure. Amen."));
        _verse.Add(new Words("4 And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things."));

        _script.Add(new Scripture(_refer[0], _verse[0]));
        _script.Add(new Scripture(_refer[1], _verse[1]));
        _script.Add(new Scripture(_refer[2], _verse[2]));
        _script.Add(new Scripture(_refer[3], _verse[3]));
        _script.Add(new Scripture(_refer[4], _verse[4]));
        _script.Add(new Scripture(_refer[5], _verse[5]));
        _script.Add(new Scripture(_refer[6], _verse[6]));
        _script.Add(new Scripture(_refer[7], _verse[7]));
        _script.Add(new Scripture(_refer[8], _verse[8]));
        _script.Add(new Scripture(_refer[9], _verse[9]));
        _script.Add(new Scripture(_refer[10], _verse[10]));
        _script.Add(new Scripture(_refer[11], _verse[11]));
        _script.Add(new Scripture(_refer[12], _verse[12]));
        _script.Add(new Scripture(_refer[13], _verse[13]));
        _script.Add(new Scripture(_refer[14], _verse[14]));
        _script.Add(new Scripture(_refer[15], _verse[15]));
        _script.Add(new Scripture(_refer[16], _verse[16]));
        _script.Add(new Scripture(_refer[17], _verse[17]));
        _script.Add(new Scripture(_refer[18], _verse[18]));
        _script.Add(new Scripture(_refer[19], _verse[19]));
        _script.Add(new Scripture(_refer[20], _verse[20]));
        _script.Add(new Scripture(_refer[21], _verse[21]));
        _script.Add(new Scripture(_refer[22], _verse[22]));
        _script.Add(new Scripture(_refer[23], _verse[23]));
        _script.Add(new Scripture(_refer[24], _verse[24]));
        _script.Add(new Scripture(_refer[25], _verse[25]));
        _script.Add(new Scripture(_refer[26], _verse[26]));
        _script.Add(new Scripture(_refer[27], _verse[27]));
    }

    public List<Reference> GetReferTable()
    {
        return _refer;
    }

    public List<Scripture> GetScriptTable()
    {
        return _script;
    }
    public List<Words> GetVerseTable()
    {
        return _verse;
    }
}