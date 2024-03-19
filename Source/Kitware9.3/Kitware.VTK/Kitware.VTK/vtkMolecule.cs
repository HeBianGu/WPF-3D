using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMolecule
	/// </summary>
	/// <remarks>
	///    class describing a molecule
	///
	///
	///
	/// vtkMolecule and the convenience classes vtkAtom and vtkBond
	/// describe the geometry and connectivity of a molecule. The molecule
	/// can be constructed using the AppendAtom() and AppendBond() methods in one
	/// of two ways; either by fully specifying the atom/bond in a single
	/// call, or by incrementally setting the various attributes using the
	/// convenience vtkAtom and vtkBond classes:
	///
	/// Single call:
	/// <code>
	/// vtkMolecule *mol = vtkMolecule::New();
	/// vtkAtom h1 = mol-&gt;AppendAtom(1, 0.0, 0.0, -0.5);
	/// vtkAtom h2 = mol-&gt;AppendAtom(1, 0.0, 0.0,  0.5);
	/// vtkBond b  = mol-&gt;AppendBond(h1, h2, 1);
	/// </code>
	///
	/// Incremental:
	/// <code>
	/// vtkMolecule *mol = vtkMolecule::New();
	///
	/// vtkAtom h1 = mol-&gt;AppendAtom();
	/// h1.SetAtomicNumber(1);
	/// h1.SetPosition(0.0, 0.0, -0.5);
	///
	/// vtkAtom h2 = mol-&gt;AppendAtom();
	/// h2.SetAtomicNumber(1);
	/// vtkVector3d displacement (0.0, 0.0, 1.0);
	/// h2.SetPosition(h1.GetPositionAsVector3d() + displacement);
	///
	/// vtkBond b  = mol-&gt;AppendBond(h1, h2, 1);
	/// </code>
	///
	/// Both of the above methods will produce the same molecule, two
	/// hydrogens connected with a 1.0 Angstrom single bond, aligned to the
	/// z-axis. The second example also demonstrates the use of VTK's
	/// vtkVector class, which is fully supported by the Chemistry kit.
	///
	/// The vtkMolecule object is intended to be used with the
	/// vtkMoleculeMapper class for visualizing molecular structure using
	/// common rendering techniques.
	///
	/// \warning While direct use of the underlying vtkUndirectedGraph
	/// structure is possible due to vtkMolecule's public inheritance, this
	/// should not be relied upon and may change in the future.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAtom vtkBond vtkMoleculeMapper vtkPeriodicTable
	/// </seealso>
	// Token: 0x02000A83 RID: 2691
	public class vtkMolecule : vtkUndirectedGraph
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C2A6 RID: 115366 RVA: 0x002783DF File Offset: 0x002765DF
		static vtkMolecule()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMolecule.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMolecule"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C2A7 RID: 115367 RVA: 0x00278407 File Offset: 0x00276607
		public vtkMolecule(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C2A8 RID: 115368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2A9 RID: 115369 RVA: 0x00278418 File Offset: 0x00276618
		public new static vtkMolecule New()
		{
			vtkMolecule result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2AA RID: 115370 RVA: 0x0027846C File Offset: 0x0027666C
		public vtkMolecule() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMolecule.vtkMolecule_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C2AB RID: 115371 RVA: 0x002784B0 File Offset: 0x002766B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C2AC RID: 115372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_AllocateAtomGhostArray_01(HandleRef pThis);

		/// <summary>
		/// Allocate ghost array for atoms.
		/// </summary>
		// Token: 0x0601C2AD RID: 115373 RVA: 0x002784BB File Offset: 0x002766BB
		public void AllocateAtomGhostArray()
		{
			vtkMolecule.vtkMolecule_AllocateAtomGhostArray_01(base.GetCppThis());
		}

		// Token: 0x0601C2AE RID: 115374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_AllocateBondGhostArray_02(HandleRef pThis);

		/// <summary>
		/// Allocate ghost array for bonds.
		/// </summary>
		// Token: 0x0601C2AF RID: 115375 RVA: 0x002784CA File Offset: 0x002766CA
		public void AllocateBondGhostArray()
		{
			vtkMolecule.vtkMolecule_AllocateBondGhostArray_02(base.GetCppThis());
		}

		// Token: 0x0601C2B0 RID: 115376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMolecule_CheckedDeepCopy_03(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Performs the same operation as DeepCopy(),
		/// but instead of reporting an error for an incompatible graph,
		/// returns false.
		/// </summary>
		// Token: 0x0601C2B1 RID: 115377 RVA: 0x002784DC File Offset: 0x002766DC
		public override bool CheckedDeepCopy(vtkGraph g)
		{
			return vtkMolecule.vtkMolecule_CheckedDeepCopy_03(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601C2B2 RID: 115378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMolecule_CheckedShallowCopy_04(HandleRef pThis, HandleRef g);

		/// <summary>
		/// Performs the same operation as ShallowCopy(),
		/// but instead of reporting an error for an incompatible graph,
		/// returns false.
		/// </summary>
		// Token: 0x0601C2B3 RID: 115379 RVA: 0x00278518 File Offset: 0x00276718
		public override bool CheckedShallowCopy(vtkGraph g)
		{
			return vtkMolecule.vtkMolecule_CheckedShallowCopy_04(base.GetCppThis(), (g == null) ? default(HandleRef) : g.GetCppThis()) != 0;
		}

		// Token: 0x0601C2B4 RID: 115380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_ClearLattice_05(HandleRef pThis);

		/// <summary>
		/// Remove any unit cell lattice information from the molecule.
		/// </summary>
		// Token: 0x0601C2B5 RID: 115381 RVA: 0x00278553 File Offset: 0x00276753
		public void ClearLattice()
		{
			vtkMolecule.vtkMolecule_ClearLattice_05(base.GetCppThis());
		}

		// Token: 0x0601C2B6 RID: 115382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_DeepCopy_06(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Deep copies the data object into this molecule.
		/// </summary>
		// Token: 0x0601C2B7 RID: 115383 RVA: 0x00278564 File Offset: 0x00276764
		public override void DeepCopy(vtkDataObject obj)
		{
			vtkMolecule.vtkMolecule_DeepCopy_06(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0601C2B8 RID: 115384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_DeepCopyAttributes_07(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Deep copies attributes (i.e. everything besides atoms and bonds) from
		/// @a m into @a this.
		/// </summary>
		// Token: 0x0601C2B9 RID: 115385 RVA: 0x00278594 File Offset: 0x00276794
		public virtual void DeepCopyAttributes(vtkMolecule m)
		{
			vtkMolecule.vtkMolecule_DeepCopyAttributes_07(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x0601C2BA RID: 115386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_DeepCopyStructure_08(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Deep copies the atoms and bonds from @a m into @a this.
		/// </summary>
		// Token: 0x0601C2BB RID: 115387 RVA: 0x002785C4 File Offset: 0x002767C4
		public virtual void DeepCopyStructure(vtkMolecule m)
		{
			vtkMolecule.vtkMolecule_DeepCopyStructure_08(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x0601C2BC RID: 115388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkMolecule_GetActualMemorySize_09(HandleRef pThis);

		/// <summary>
		/// Return the actual size of the data in kibibytes (1024 bytes). This number
		/// is valid only after the pipeline has updated. The memory size
		/// returned is guaranteed to be greater than or equal to the
		/// memory required to represent the data (e.g., extra space in
		/// arrays, etc. are not included in the return value).
		/// </summary>
		// Token: 0x0601C2BD RID: 115389 RVA: 0x002785F4 File Offset: 0x002767F4
		public override uint GetActualMemorySize()
		{
			return vtkMolecule.vtkMolecule_GetActualMemorySize_09(base.GetCppThis());
		}

		// Token: 0x0601C2BE RID: 115390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkMolecule_GetAtomAtomicNumber_10(HandleRef pThis, long atomId);

		/// <summary>
		/// Return the atomic number of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C2BF RID: 115391 RVA: 0x00278614 File Offset: 0x00276814
		public ushort GetAtomAtomicNumber(long atomId)
		{
			return vtkMolecule.vtkMolecule_GetAtomAtomicNumber_10(base.GetCppThis(), atomId);
		}

		// Token: 0x0601C2C0 RID: 115392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomData_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the VertexData of the underlying graph
		/// </summary>
		// Token: 0x0601C2C1 RID: 115393 RVA: 0x00278634 File Offset: 0x00276834
		public vtkDataSetAttributes GetAtomData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetAtomData_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601C2C2 RID: 115394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomGhostArray_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array that defines the ghost type of each atom.
		/// </summary>
		// Token: 0x0601C2C3 RID: 115395 RVA: 0x002786A4 File Offset: 0x002768A4
		public vtkUnsignedCharArray GetAtomGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetAtomGhostArray_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0601C2C4 RID: 115396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomPosition_13(HandleRef pThis, long atomId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the position of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C2C5 RID: 115397 RVA: 0x00278714 File Offset: 0x00276914
		public vtkVector3f GetAtomPosition(long atomId)
		{
			vtkVector3f result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetAtomPosition_13(base.GetCppThis(), atomId, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3f)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C2C6 RID: 115398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_GetAtomPosition_14(HandleRef pThis, long atomId, IntPtr pos);

		/// <summary>
		/// Get the position of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C2C7 RID: 115399 RVA: 0x0027876F File Offset: 0x0027696F
		public void GetAtomPosition(long atomId, IntPtr pos)
		{
			vtkMolecule.vtkMolecule_GetAtomPosition_14(base.GetCppThis(), atomId, pos);
		}

		// Token: 0x0601C2C8 RID: 115400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomicNumberArray_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the raw arrays used in this vtkMolecule instance
		/// </summary>
		// Token: 0x0601C2C9 RID: 115401 RVA: 0x00278780 File Offset: 0x00276980
		public vtkUnsignedShortArray GetAtomicNumberArray()
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetAtomicNumberArray_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		// Token: 0x0601C2CA RID: 115402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomicNumberArrayName_16(HandleRef pThis);

		/// <summary>
		/// Get/Set the atomic number array name.
		/// </summary>
		// Token: 0x0601C2CB RID: 115403 RVA: 0x002787F0 File Offset: 0x002769F0
		public virtual string GetAtomicNumberArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMolecule.vtkMolecule_GetAtomicNumberArrayName_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601C2CC RID: 115404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetAtomicPositionArray_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the raw arrays used in this vtkMolecule instance
		/// </summary>
		// Token: 0x0601C2CD RID: 115405 RVA: 0x0027882C File Offset: 0x00276A2C
		public vtkPoints GetAtomicPositionArray()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetAtomicPositionArray_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x0601C2CE RID: 115406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetBondData_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the EdgeData of the underlying graph
		/// </summary>
		// Token: 0x0601C2CF RID: 115407 RVA: 0x0027889C File Offset: 0x00276A9C
		public vtkDataSetAttributes GetBondData()
		{
			vtkDataSetAttributes vtkDataSetAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetBondData_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSetAttributes = (vtkDataSetAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSetAttributes.Register(null);
				}
			}
			return vtkDataSetAttributes;
		}

		// Token: 0x0601C2D0 RID: 115408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetBondGhostArray_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the array that defines the ghost type of each bond.
		/// </summary>
		// Token: 0x0601C2D1 RID: 115409 RVA: 0x0027890C File Offset: 0x00276B0C
		public vtkUnsignedCharArray GetBondGhostArray()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetBondGhostArray_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0601C2D2 RID: 115410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMolecule_GetBondId_20(HandleRef pThis, long a, long b);

		/// <summary>
		/// Return the edge id from the underlying graph.
		/// </summary>
		// Token: 0x0601C2D3 RID: 115411 RVA: 0x0027897C File Offset: 0x00276B7C
		public long GetBondId(long a, long b)
		{
			return vtkMolecule.vtkMolecule_GetBondId_20(base.GetCppThis(), a, b);
		}

		// Token: 0x0601C2D4 RID: 115412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMolecule_GetBondLength_21(HandleRef pThis, long bondId);

		/// <summary>
		/// Get the bond length of the bond with the specified id
		///
		/// \note If the associated vtkBond object is already available,
		/// vtkBond::GetBondLength is potentially much faster than this
		/// function, as a list of all bonds may need to be constructed to
		/// locate the appropriate bond.
		/// \sa UpdateBondList()
		/// </summary>
		// Token: 0x0601C2D5 RID: 115413 RVA: 0x002789A0 File Offset: 0x00276BA0
		public double GetBondLength(long bondId)
		{
			return vtkMolecule.vtkMolecule_GetBondLength_21(base.GetCppThis(), bondId);
		}

		// Token: 0x0601C2D6 RID: 115414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ushort vtkMolecule_GetBondOrder_22(HandleRef pThis, long bondId);

		/// <summary>
		/// Get/Set the bond order of the bond with the specified id
		/// </summary>
		// Token: 0x0601C2D7 RID: 115415 RVA: 0x002789C0 File Offset: 0x00276BC0
		public ushort GetBondOrder(long bondId)
		{
			return vtkMolecule.vtkMolecule_GetBondOrder_22(base.GetCppThis(), bondId);
		}

		// Token: 0x0601C2D8 RID: 115416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetBondOrdersArray_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access the raw arrays used in this vtkMolecule instance
		/// </summary>
		// Token: 0x0601C2D9 RID: 115417 RVA: 0x002789E0 File Offset: 0x00276BE0
		public vtkUnsignedShortArray GetBondOrdersArray()
		{
			vtkUnsignedShortArray vtkUnsignedShortArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetBondOrdersArray_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedShortArray = (vtkUnsignedShortArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedShortArray.Register(null);
				}
			}
			return vtkUnsignedShortArray;
		}

		// Token: 0x0601C2DA RID: 115418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetBondOrdersArrayName_24(HandleRef pThis);

		/// <summary>
		/// Get/Set the bond orders array name.
		/// </summary>
		// Token: 0x0601C2DB RID: 115419 RVA: 0x00278A50 File Offset: 0x00276C50
		public virtual string GetBondOrdersArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMolecule.vtkMolecule_GetBondOrdersArrayName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601C2DC RID: 115420
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetData_25(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a molecule from an information vector.
		/// </summary>
		// Token: 0x0601C2DD RID: 115421 RVA: 0x00278A8C File Offset: 0x00276C8C
		public new static vtkMolecule GetData(vtkInformation info)
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetData_25((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x0601C2DE RID: 115422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetData_26(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve a molecule from an information vector.
		/// </summary>
		// Token: 0x0601C2DF RID: 115423 RVA: 0x00278B0C File Offset: 0x00276D0C
		public new static vtkMolecule GetData(vtkInformationVector v, int i)
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetData_26((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x0601C2E0 RID: 115424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_GetDataObjectType_27(HandleRef pThis);

		/// <summary>
		/// Return what type of dataset this is.
		/// </summary>
		// Token: 0x0601C2E1 RID: 115425 RVA: 0x00278B8C File Offset: 0x00276D8C
		public override int GetDataObjectType()
		{
			return vtkMolecule.vtkMolecule_GetDataObjectType_27(base.GetCppThis());
		}

		// Token: 0x0601C2E2 RID: 115426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetElectronicData_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the AbstractElectronicData-subclassed object for this molecule.
		/// </summary>
		// Token: 0x0601C2E3 RID: 115427 RVA: 0x00278BAC File Offset: 0x00276DAC
		public virtual vtkAbstractElectronicData GetElectronicData()
		{
			vtkAbstractElectronicData vtkAbstractElectronicData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetElectronicData_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractElectronicData = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractElectronicData.Register(null);
				}
			}
			return vtkAbstractElectronicData;
		}

		// Token: 0x0601C2E4 RID: 115428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetLattice_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the unit cell lattice vectors. The matrix is stored using a row-major
		/// layout, with the vectors encoded as columns. Will return nullptr if no
		/// unit cell information is available.
		/// @sa GetLatticeOrigin
		/// </summary>
		// Token: 0x0601C2E5 RID: 115429 RVA: 0x00278C1C File Offset: 0x00276E1C
		public vtkMatrix3x3 GetLattice()
		{
			vtkMatrix3x3 vtkMatrix3x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetLattice_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix3x = (vtkMatrix3x3)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix3x.Register(null);
				}
			}
			return vtkMatrix3x;
		}

		// Token: 0x0601C2E6 RID: 115430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_GetLattice_30(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c);

		/// <summary>
		/// Get the unit cell lattice vectors, and optionally, the origin.
		/// </summary>
		// Token: 0x0601C2E7 RID: 115431 RVA: 0x00278C8C File Offset: 0x00276E8C
		public void GetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c)
		{
			vtkMolecule.vtkMolecule_GetLattice_30(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601C2E8 RID: 115432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_GetLattice_31(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c, HandleRef origin);

		/// <summary>
		/// Get the unit cell lattice vectors, and optionally, the origin.
		/// </summary>
		// Token: 0x0601C2E9 RID: 115433 RVA: 0x00278CE8 File Offset: 0x00276EE8
		public void GetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c, vtkVector3d origin)
		{
			vtkMolecule.vtkMolecule_GetLattice_31(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis(), (origin == null) ? default(HandleRef) : origin.GetCppThis());
		}

		// Token: 0x0601C2EA RID: 115434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_GetLatticeOrigin_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the unit cell origin (for rendering purposes).
		/// </summary>
		// Token: 0x0601C2EB RID: 115435 RVA: 0x00278D58 File Offset: 0x00276F58
		public virtual vtkVector3d GetLatticeOrigin()
		{
			vtkVector3d result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_GetLatticeOrigin_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVector3d)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C2EC RID: 115436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMolecule_GetNumberOfAtoms_33(HandleRef pThis);

		/// <summary>
		/// Return the number of atoms in the molecule.
		/// </summary>
		// Token: 0x0601C2ED RID: 115437 RVA: 0x00278DB4 File Offset: 0x00276FB4
		public long GetNumberOfAtoms()
		{
			return vtkMolecule.vtkMolecule_GetNumberOfAtoms_33(base.GetCppThis());
		}

		// Token: 0x0601C2EE RID: 115438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMolecule_GetNumberOfBonds_34(HandleRef pThis);

		/// <summary>
		/// Return the number of bonds in the molecule.
		/// </summary>
		// Token: 0x0601C2EF RID: 115439 RVA: 0x00278DD4 File Offset: 0x00276FD4
		public long GetNumberOfBonds()
		{
			return vtkMolecule.vtkMolecule_GetNumberOfBonds_34(base.GetCppThis());
		}

		// Token: 0x0601C2F0 RID: 115440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMolecule_GetNumberOfGenerationsFromBase_35(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2F1 RID: 115441 RVA: 0x00278DF4 File Offset: 0x00276FF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMolecule.vtkMolecule_GetNumberOfGenerationsFromBase_35(base.GetCppThis(), type);
		}

		// Token: 0x0601C2F2 RID: 115442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMolecule_GetNumberOfGenerationsFromBaseType_36([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2F3 RID: 115443 RVA: 0x00278E14 File Offset: 0x00277014
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMolecule.vtkMolecule_GetNumberOfGenerationsFromBaseType_36(type);
		}

		// Token: 0x0601C2F4 RID: 115444
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMolecule_HasLattice_37(HandleRef pThis);

		/// <summary>
		/// Return true if a unit cell lattice is defined.
		/// </summary>
		// Token: 0x0601C2F5 RID: 115445 RVA: 0x00278E30 File Offset: 0x00277030
		public bool HasLattice()
		{
			return vtkMolecule.vtkMolecule_HasLattice_37(base.GetCppThis()) != 0;
		}

		// Token: 0x0601C2F6 RID: 115446
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_Initialize_38(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2F7 RID: 115447 RVA: 0x00278E56 File Offset: 0x00277056
		public override void Initialize()
		{
			vtkMolecule.vtkMolecule_Initialize_38(base.GetCppThis());
		}

		// Token: 0x0601C2F8 RID: 115448
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_Initialize_39(HandleRef pThis, HandleRef atomPositions, HandleRef atomicNumberArray, HandleRef atomData);

		/// <summary>
		/// Initialize a molecule with an atom per input point.
		/// Parameters atomPositions and atomicNumberArray should have the same size.
		/// </summary>
		// Token: 0x0601C2F9 RID: 115449 RVA: 0x00278E68 File Offset: 0x00277068
		public int Initialize(vtkPoints atomPositions, vtkDataArray atomicNumberArray, vtkDataSetAttributes atomData)
		{
			return vtkMolecule.vtkMolecule_Initialize_39(base.GetCppThis(), (atomPositions == null) ? default(HandleRef) : atomPositions.GetCppThis(), (atomicNumberArray == null) ? default(HandleRef) : atomicNumberArray.GetCppThis(), (atomData == null) ? default(HandleRef) : atomData.GetCppThis());
		}

		// Token: 0x0601C2FA RID: 115450
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_Initialize_40(HandleRef pThis, HandleRef atomPositions, HandleRef atomData);

		/// <summary>
		/// Overloads Initialize method.
		/// </summary>
		// Token: 0x0601C2FB RID: 115451 RVA: 0x00278EC8 File Offset: 0x002770C8
		public int Initialize(vtkPoints atomPositions, vtkDataSetAttributes atomData)
		{
			return vtkMolecule.vtkMolecule_Initialize_40(base.GetCppThis(), (atomPositions == null) ? default(HandleRef) : atomPositions.GetCppThis(), (atomData == null) ? default(HandleRef) : atomData.GetCppThis());
		}

		// Token: 0x0601C2FC RID: 115452
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_Initialize_41(HandleRef pThis, HandleRef molecule);

		/// <summary>
		/// Use input molecule points, atomic number and atomic data to initialize the new molecule.
		/// </summary>
		// Token: 0x0601C2FD RID: 115453 RVA: 0x00278F14 File Offset: 0x00277114
		public int Initialize(vtkMolecule molecule)
		{
			return vtkMolecule.vtkMolecule_Initialize_41(base.GetCppThis(), (molecule == null) ? default(HandleRef) : molecule.GetCppThis());
		}

		// Token: 0x0601C2FE RID: 115454
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_IsA_42(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C2FF RID: 115455 RVA: 0x00278F48 File Offset: 0x00277148
		public override int IsA(string type)
		{
			return vtkMolecule.vtkMolecule_IsA_42(base.GetCppThis(), type);
		}

		// Token: 0x0601C300 RID: 115456
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMolecule_IsTypeOf_43([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C301 RID: 115457 RVA: 0x00278F68 File Offset: 0x00277168
		public new static int IsTypeOf(string type)
		{
			return vtkMolecule.vtkMolecule_IsTypeOf_43(type);
		}

		// Token: 0x0601C302 RID: 115458
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_NewInstance_45(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C303 RID: 115459 RVA: 0x00278F84 File Offset: 0x00277184
		public new vtkMolecule NewInstance()
		{
			vtkMolecule result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_NewInstance_45(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C304 RID: 115460
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMolecule_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C305 RID: 115461 RVA: 0x00278FE0 File Offset: 0x002771E0
		public new static vtkMolecule SafeDownCast(vtkObjectBase o)
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMolecule.vtkMolecule_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x0601C306 RID: 115462
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetAtomAtomicNumber_47(HandleRef pThis, long atomId, ushort atomicNum);

		/// <summary>
		/// Set the atomic number of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C307 RID: 115463 RVA: 0x0027905F File Offset: 0x0027725F
		public void SetAtomAtomicNumber(long atomId, ushort atomicNum)
		{
			vtkMolecule.vtkMolecule_SetAtomAtomicNumber_47(base.GetCppThis(), atomId, atomicNum);
		}

		// Token: 0x0601C308 RID: 115464
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetAtomPosition_48(HandleRef pThis, long atomId, HandleRef pos);

		/// <summary>
		/// Set the position of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C309 RID: 115465 RVA: 0x00279070 File Offset: 0x00277270
		public void SetAtomPosition(long atomId, vtkVector3f pos)
		{
			vtkMolecule.vtkMolecule_SetAtomPosition_48(base.GetCppThis(), atomId, (pos == null) ? default(HandleRef) : pos.GetCppThis());
		}

		// Token: 0x0601C30A RID: 115466
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetAtomPosition_49(HandleRef pThis, long atomId, double x, double y, double z);

		/// <summary>
		/// Set the position of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C30B RID: 115467 RVA: 0x002790A0 File Offset: 0x002772A0
		public void SetAtomPosition(long atomId, double x, double y, double z)
		{
			vtkMolecule.vtkMolecule_SetAtomPosition_49(base.GetCppThis(), atomId, x, y, z);
		}

		// Token: 0x0601C30C RID: 115468
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetAtomPosition_50(HandleRef pThis, long atomId, IntPtr pos);

		/// <summary>
		/// Set the position of the atom with the specified id.
		/// </summary>
		// Token: 0x0601C30D RID: 115469 RVA: 0x002790B4 File Offset: 0x002772B4
		public void SetAtomPosition(long atomId, IntPtr pos)
		{
			vtkMolecule.vtkMolecule_SetAtomPosition_50(base.GetCppThis(), atomId, pos);
		}

		// Token: 0x0601C30E RID: 115470
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetAtomicNumberArrayName_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the atomic number array name.
		/// </summary>
		// Token: 0x0601C30F RID: 115471 RVA: 0x002790C5 File Offset: 0x002772C5
		public virtual void SetAtomicNumberArrayName(string _arg)
		{
			vtkMolecule.vtkMolecule_SetAtomicNumberArrayName_51(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C310 RID: 115472
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetBondOrder_52(HandleRef pThis, long bondId, ushort order);

		/// <summary>
		/// Get/Set the bond order of the bond with the specified id
		/// </summary>
		// Token: 0x0601C311 RID: 115473 RVA: 0x002790D5 File Offset: 0x002772D5
		public void SetBondOrder(long bondId, ushort order)
		{
			vtkMolecule.vtkMolecule_SetBondOrder_52(base.GetCppThis(), bondId, order);
		}

		// Token: 0x0601C312 RID: 115474
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetBondOrdersArrayName_53(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the bond orders array name.
		/// </summary>
		// Token: 0x0601C313 RID: 115475 RVA: 0x002790E6 File Offset: 0x002772E6
		public virtual void SetBondOrdersArrayName(string _arg)
		{
			vtkMolecule.vtkMolecule_SetBondOrdersArrayName_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0601C314 RID: 115476
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetElectronicData_54(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the AbstractElectronicData-subclassed object for this molecule.
		/// </summary>
		// Token: 0x0601C315 RID: 115477 RVA: 0x002790F8 File Offset: 0x002772F8
		public virtual void SetElectronicData(vtkAbstractElectronicData arg0)
		{
			vtkMolecule.vtkMolecule_SetElectronicData_54(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601C316 RID: 115478
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetLattice_55(HandleRef pThis, HandleRef matrix);

		/// <summary>
		/// The unit cell vectors. The matrix is stored using a row-major layout, with
		/// the vectors encoded as columns.
		/// </summary>
		// Token: 0x0601C317 RID: 115479 RVA: 0x00279128 File Offset: 0x00277328
		public void SetLattice(vtkMatrix3x3 matrix)
		{
			vtkMolecule.vtkMolecule_SetLattice_55(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x0601C318 RID: 115480
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetLattice_56(HandleRef pThis, HandleRef a, HandleRef b, HandleRef c);

		/// <summary>
		/// The unit cell vectors. The matrix is stored using a row-major layout, with
		/// the vectors encoded as columns.
		/// </summary>
		// Token: 0x0601C319 RID: 115481 RVA: 0x00279158 File Offset: 0x00277358
		public void SetLattice(vtkVector3d a, vtkVector3d b, vtkVector3d c)
		{
			vtkMolecule.vtkMolecule_SetLattice_56(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (b == null) ? default(HandleRef) : b.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601C31A RID: 115482
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_SetLatticeOrigin_57(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// Get the unit cell origin (for rendering purposes).
		/// </summary>
		// Token: 0x0601C31B RID: 115483 RVA: 0x002791B4 File Offset: 0x002773B4
		public virtual void SetLatticeOrigin(vtkVector3d _arg)
		{
			vtkMolecule.vtkMolecule_SetLatticeOrigin_57(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		// Token: 0x0601C31C RID: 115484
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_ShallowCopy_58(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Shallow copies the data object into this molecule.
		/// </summary>
		// Token: 0x0601C31D RID: 115485 RVA: 0x002791E4 File Offset: 0x002773E4
		public override void ShallowCopy(vtkDataObject obj)
		{
			vtkMolecule.vtkMolecule_ShallowCopy_58(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x0601C31E RID: 115486
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_ShallowCopyAttributes_59(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Shallow copies attributes (i.e. everything besides atoms and bonds) from
		/// @a m into @a this.
		/// </summary>
		// Token: 0x0601C31F RID: 115487 RVA: 0x00279214 File Offset: 0x00277414
		public virtual void ShallowCopyAttributes(vtkMolecule m)
		{
			vtkMolecule.vtkMolecule_ShallowCopyAttributes_59(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		// Token: 0x0601C320 RID: 115488
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMolecule_ShallowCopyStructure_60(HandleRef pThis, HandleRef m);

		/// <summary>
		/// Shallow copies the atoms and bonds from @a m into @a this.
		/// </summary>
		// Token: 0x0601C321 RID: 115489 RVA: 0x00279244 File Offset: 0x00277444
		public virtual void ShallowCopyStructure(vtkMolecule m)
		{
			vtkMolecule.vtkMolecule_ShallowCopyStructure_60(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E02 RID: 7682
		public new const string MRFullTypeName = "Kitware.VTK.vtkMolecule";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E03 RID: 7683
		public new static readonly string MRClassNameKey = "class vtkMolecule";
	}
}
