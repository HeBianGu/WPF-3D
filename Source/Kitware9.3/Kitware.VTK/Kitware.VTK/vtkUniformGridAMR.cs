using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUniformGridAMR
	/// </summary>
	/// <remarks>
	///    a concrete implementation of vtkCompositeDataSet
	///
	/// vtkUniformGridAMR is an AMR (hierarchical) composite dataset that holds vtkUniformGrids.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUniformGridAMRDataIterator
	/// </seealso>
	// Token: 0x02000A5A RID: 2650
	public class vtkUniformGridAMR : vtkCompositeDataSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BAC6 RID: 113350 RVA: 0x0026BD8B File Offset: 0x00269F8B
		static vtkUniformGridAMR()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUniformGridAMR.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniformGridAMR"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BAC7 RID: 113351 RVA: 0x0026BDB3 File Offset: 0x00269FB3
		public vtkUniformGridAMR(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BAC8 RID: 113352
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAC9 RID: 113353 RVA: 0x0026BDC4 File Offset: 0x00269FC4
		public new static vtkUniformGridAMR New()
		{
			vtkUniformGridAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BACA RID: 113354 RVA: 0x0026BE18 File Offset: 0x0026A018
		public vtkUniformGridAMR() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUniformGridAMR.vtkUniformGridAMR_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BACB RID: 113355 RVA: 0x0026BE5C File Offset: 0x0026A05C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BACC RID: 113356
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_CompositeShallowCopy_01(HandleRef pThis, HandleRef src);

		/// <summary>
		/// ShallowCopy.
		/// </summary>
		// Token: 0x0601BACD RID: 113357 RVA: 0x0026BE68 File Offset: 0x0026A068
		public override void CompositeShallowCopy(vtkCompositeDataSet src)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_CompositeShallowCopy_01(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601BACE RID: 113358
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_CopyStructure_02(HandleRef pThis, HandleRef src);

		/// <summary>
		/// CopyStructure.
		/// </summary>
		// Token: 0x0601BACF RID: 113359 RVA: 0x0026BE98 File Offset: 0x0026A098
		public override void CopyStructure(vtkCompositeDataSet src)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_CopyStructure_02(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601BAD0 RID: 113360
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_DeepCopy_03(HandleRef pThis, HandleRef src);

		/// <summary>
		/// DeepCopy.
		/// </summary>
		// Token: 0x0601BAD1 RID: 113361 RVA: 0x0026BEC8 File Offset: 0x0026A0C8
		public override void DeepCopy(vtkDataObject src)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_DeepCopy_03(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601BAD2 RID: 113362
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the (min/max) bounds of the AMR domain.
		/// </summary>
		// Token: 0x0601BAD3 RID: 113363 RVA: 0x0026BEF7 File Offset: 0x0026A0F7
		public new void GetBounds(IntPtr bounds)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x0601BAD4 RID: 113364
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Get the (min/max) bounds of the AMR domain.
		/// </summary>
		// Token: 0x0601BAD5 RID: 113365 RVA: 0x0026BF08 File Offset: 0x0026A108
		public IntPtr GetBounds()
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetBounds_05(base.GetCppThis());
		}

		// Token: 0x0601BAD6 RID: 113366
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMR_GetCompositeIndex_06(HandleRef pThis, uint level, uint index);

		/// <summary>
		/// Retrieves the composite index associated with the data at the given
		/// (level,index) pair.
		/// </summary>
		// Token: 0x0601BAD7 RID: 113367 RVA: 0x0026BF28 File Offset: 0x0026A128
		public int GetCompositeIndex(uint level, uint index)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetCompositeIndex_06(base.GetCppThis(), level, index);
		}

		// Token: 0x0601BAD8 RID: 113368
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_GetData_07(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BAD9 RID: 113369 RVA: 0x0026BF4C File Offset: 0x0026A14C
		public new static vtkUniformGridAMR GetData(vtkInformation info)
		{
			vtkUniformGridAMR vtkUniformGridAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_GetData_07((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMR = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMR.Register(null);
				}
			}
			return vtkUniformGridAMR;
		}

		// Token: 0x0601BADA RID: 113370
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_GetData_08(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Retrieve an instance of this class from an information object.
		/// </summary>
		// Token: 0x0601BADB RID: 113371 RVA: 0x0026BFCC File Offset: 0x0026A1CC
		public new static vtkUniformGridAMR GetData(vtkInformationVector v, int i)
		{
			vtkUniformGridAMR vtkUniformGridAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_GetData_08((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMR = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMR.Register(null);
				}
			}
			return vtkUniformGridAMR;
		}

		// Token: 0x0601BADC RID: 113372
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMR_GetDataObjectType_09(HandleRef pThis);

		/// <summary>
		/// Return class name of data type (see vtkType.h for definitions).
		/// </summary>
		// Token: 0x0601BADD RID: 113373 RVA: 0x0026C04C File Offset: 0x0026A24C
		public override int GetDataObjectType()
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetDataObjectType_09(base.GetCppThis());
		}

		// Token: 0x0601BADE RID: 113374
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_GetDataSet_10(HandleRef pThis, HandleRef iter, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data set pointed to by iter
		/// </summary>
		// Token: 0x0601BADF RID: 113375 RVA: 0x0026C06C File Offset: 0x0026A26C
		public override vtkDataObject GetDataSet(vtkCompositeDataIterator iter)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_GetDataSet_10(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601BAE0 RID: 113376
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_GetDataSet_11(HandleRef pThis, uint level, uint idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the data set using the (level, index) pair.
		/// </summary>
		// Token: 0x0601BAE1 RID: 113377 RVA: 0x0026C0F4 File Offset: 0x0026A2F4
		public vtkUniformGrid GetDataSet(uint level, uint idx)
		{
			vtkUniformGrid vtkUniformGrid = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_GetDataSet_11(base.GetCppThis(), level, idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGrid = (vtkUniformGrid)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGrid.Register(null);
				}
			}
			return vtkUniformGrid;
		}

		// Token: 0x0601BAE2 RID: 113378
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMR_GetGridDescription_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the data description of this uniform grid instance,
		/// e.g. VTK_XYZ_GRID
		/// </summary>
		// Token: 0x0601BAE3 RID: 113379 RVA: 0x0026C168 File Offset: 0x0026A368
		public int GetGridDescription()
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetGridDescription_12(base.GetCppThis());
		}

		// Token: 0x0601BAE4 RID: 113380
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_GetLevelAndIndex_13(HandleRef pThis, uint compositeIdx, ref uint level, ref uint idx);

		/// <summary>
		/// Given the compositeIdx (as set by SetCompositeIdx) this method returns the
		/// corresponding level and dataset index within the level.
		/// </summary>
		// Token: 0x0601BAE5 RID: 113381 RVA: 0x0026C187 File Offset: 0x0026A387
		public void GetLevelAndIndex(uint compositeIdx, ref uint level, ref uint idx)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_GetLevelAndIndex_13(base.GetCppThis(), compositeIdx, ref level, ref idx);
		}

		// Token: 0x0601BAE6 RID: 113382
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_GetMax_14(HandleRef pThis, IntPtr max);

		/// <summary>
		/// Get the (min/max) bounds of the AMR domain.
		/// </summary>
		// Token: 0x0601BAE7 RID: 113383 RVA: 0x0026C199 File Offset: 0x0026A399
		public void GetMax(IntPtr max)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_GetMax_14(base.GetCppThis(), max);
		}

		// Token: 0x0601BAE8 RID: 113384
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_GetMin_15(HandleRef pThis, IntPtr min);

		/// <summary>
		/// Get the (min/max) bounds of the AMR domain.
		/// </summary>
		// Token: 0x0601BAE9 RID: 113385 RVA: 0x0026C1A9 File Offset: 0x0026A3A9
		public void GetMin(IntPtr min)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_GetMin_15(base.GetCppThis(), min);
		}

		// Token: 0x0601BAEA RID: 113386
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMR_GetNumberOfDataSets_16(HandleRef pThis, uint level);

		/// <summary>
		/// Get the number of datasets at the given level, including null blocks
		/// </summary>
		// Token: 0x0601BAEB RID: 113387 RVA: 0x0026C1BC File Offset: 0x0026A3BC
		public uint GetNumberOfDataSets(uint level)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetNumberOfDataSets_16(base.GetCppThis(), level);
		}

		// Token: 0x0601BAEC RID: 113388
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMR_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAED RID: 113389 RVA: 0x0026C1DC File Offset: 0x0026A3DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0601BAEE RID: 113390
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUniformGridAMR_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAEF RID: 113391 RVA: 0x0026C1FC File Offset: 0x0026A3FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0601BAF0 RID: 113392
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMR_GetNumberOfLevels_19(HandleRef pThis);

		/// <summary>
		/// Get number of levels.
		/// </summary>
		// Token: 0x0601BAF1 RID: 113393 RVA: 0x0026C218 File Offset: 0x0026A418
		public uint GetNumberOfLevels()
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetNumberOfLevels_19(base.GetCppThis());
		}

		// Token: 0x0601BAF2 RID: 113394
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkUniformGridAMR_GetTotalNumberOfBlocks_20(HandleRef pThis);

		/// <summary>
		/// Get the total number of blocks, including nullptr blocks
		/// </summary>
		// Token: 0x0601BAF3 RID: 113395 RVA: 0x0026C238 File Offset: 0x0026A438
		public virtual uint GetTotalNumberOfBlocks()
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_GetTotalNumberOfBlocks_20(base.GetCppThis());
		}

		// Token: 0x0601BAF4 RID: 113396
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_Initialize_21(HandleRef pThis);

		/// <summary>
		/// Restore data object to initial state.
		/// </summary>
		// Token: 0x0601BAF5 RID: 113397 RVA: 0x0026C257 File Offset: 0x0026A457
		public override void Initialize()
		{
			vtkUniformGridAMR.vtkUniformGridAMR_Initialize_21(base.GetCppThis());
		}

		// Token: 0x0601BAF6 RID: 113398
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_Initialize_22(HandleRef pThis, int numLevels, IntPtr blocksPerLevel);

		/// <summary>
		/// Initialize the AMR with a specified number of levels and the blocks per level.
		/// </summary>
		// Token: 0x0601BAF7 RID: 113399 RVA: 0x0026C266 File Offset: 0x0026A466
		public virtual void Initialize(int numLevels, IntPtr blocksPerLevel)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_Initialize_22(base.GetCppThis(), numLevels, blocksPerLevel);
		}

		// Token: 0x0601BAF8 RID: 113400
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMR_IsA_23(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAF9 RID: 113401 RVA: 0x0026C278 File Offset: 0x0026A478
		public override int IsA(string type)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_IsA_23(base.GetCppThis(), type);
		}

		// Token: 0x0601BAFA RID: 113402
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUniformGridAMR_IsTypeOf_24([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAFB RID: 113403 RVA: 0x0026C298 File Offset: 0x0026A498
		public new static int IsTypeOf(string type)
		{
			return vtkUniformGridAMR.vtkUniformGridAMR_IsTypeOf_24(type);
		}

		// Token: 0x0601BAFC RID: 113404
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAFD RID: 113405 RVA: 0x0026C2B4 File Offset: 0x0026A4B4
		public new vtkUniformGridAMR NewInstance()
		{
			vtkUniformGridAMR result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_NewInstance_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BAFE RID: 113406
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_NewIterator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return a new iterator (the iterator has to be deleted by the user).
		/// </summary>
		// Token: 0x0601BAFF RID: 113407 RVA: 0x0026C310 File Offset: 0x0026A510
		public override vtkCompositeDataIterator NewIterator()
		{
			vtkCompositeDataIterator vtkCompositeDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_NewIterator_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeDataIterator = (vtkCompositeDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeDataIterator.Register(null);
				}
			}
			return vtkCompositeDataIterator;
		}

		// Token: 0x0601BB00 RID: 113408
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUniformGridAMR_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BB01 RID: 113409 RVA: 0x0026C380 File Offset: 0x0026A580
		public new static vtkUniformGridAMR SafeDownCast(vtkObjectBase o)
		{
			vtkUniformGridAMR vtkUniformGridAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUniformGridAMR.vtkUniformGridAMR_SafeDownCast_28((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUniformGridAMR = (vtkUniformGridAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUniformGridAMR.Register(null);
				}
			}
			return vtkUniformGridAMR;
		}

		// Token: 0x0601BB02 RID: 113410
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_SetDataSet_29(HandleRef pThis, HandleRef iter, HandleRef dataObj);

		/// <summary>
		/// Overriding superclass method.
		/// </summary>
		// Token: 0x0601BB03 RID: 113411 RVA: 0x0026C400 File Offset: 0x0026A600
		public override void SetDataSet(vtkCompositeDataIterator iter, vtkDataObject dataObj)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_SetDataSet_29(base.GetCppThis(), (iter == null) ? default(HandleRef) : iter.GetCppThis(), (dataObj == null) ? default(HandleRef) : dataObj.GetCppThis());
		}

		// Token: 0x0601BB04 RID: 113412
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_SetDataSet_30(HandleRef pThis, uint level, uint idx, HandleRef grid);

		/// <summary>
		/// At the passed in level, set grid as the idx'th block at that level. idx must be less
		/// than the number of data sets at that level
		/// </summary>
		// Token: 0x0601BB05 RID: 113413 RVA: 0x0026C444 File Offset: 0x0026A644
		public virtual void SetDataSet(uint level, uint idx, vtkUniformGrid grid)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_SetDataSet_30(base.GetCppThis(), level, idx, (grid == null) ? default(HandleRef) : grid.GetCppThis());
		}

		// Token: 0x0601BB06 RID: 113414
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_SetGridDescription_31(HandleRef pThis, int gridDescription);

		/// <summary>
		/// Set/Get the data description of this uniform grid instance,
		/// e.g. VTK_XYZ_GRID
		/// </summary>
		// Token: 0x0601BB07 RID: 113415 RVA: 0x0026C475 File Offset: 0x0026A675
		public void SetGridDescription(int gridDescription)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_SetGridDescription_31(base.GetCppThis(), gridDescription);
		}

		// Token: 0x0601BB08 RID: 113416
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUniformGridAMR_ShallowCopy_32(HandleRef pThis, HandleRef src);

		/// <summary>
		/// ShallowCopy.
		/// </summary>
		// Token: 0x0601BB09 RID: 113417 RVA: 0x0026C488 File Offset: 0x0026A688
		public override void ShallowCopy(vtkDataObject src)
		{
			vtkUniformGridAMR.vtkUniformGridAMR_ShallowCopy_32(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA8 RID: 7592
		public new const string MRFullTypeName = "Kitware.VTK.vtkUniformGridAMR";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA9 RID: 7593
		public new static readonly string MRClassNameKey = "class vtkUniformGridAMR";
	}
}
