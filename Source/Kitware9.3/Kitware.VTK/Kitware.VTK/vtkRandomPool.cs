using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRandomPool
	/// </summary>
	/// <remarks>
	///    convenience class to quickly generate a pool of random numbers
	///
	/// vtkRandomPool generates random numbers, and can do so using
	/// multithreading.  It supports parallel applications where generating random
	/// numbers on the fly is difficult (i.e., non-deterministic). Also, it can be
	/// used to populate vtkDataArrays in an efficient manner. By default it uses
	/// an instance of vtkMersenneTwister to generate random sequences, but any
	/// subclass of vtkRandomSequence may be used. It also supports simple methods
	/// to generate, access, and pass random memory pools between objects.
	///
	/// In threaded applications, these class may be conveniently used to
	/// pre-generate a sequence of random numbers, followed by the use of
	/// deterministic accessor methods to produce random sequences without
	/// problems etc. due to unpredictable work load and order of thread
	/// execution.
	///
	/// @warning
	/// The class uses vtkMultiThreader if the size of the pool is larger than
	/// the specified chunk size. Also, vtkSMPTools may be used to scale the
	/// components in the method PopulateDataArray().
	/// </remarks>
	// Token: 0x02000B7B RID: 2939
	public class vtkRandomPool : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EAC9 RID: 125641 RVA: 0x002B7F93 File Offset: 0x002B6193
		static vtkRandomPool()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomPool.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomPool"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EACA RID: 125642 RVA: 0x002B7FBB File Offset: 0x002B61BB
		public vtkRandomPool(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EACB RID: 125643
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EACC RID: 125644 RVA: 0x002B7FCC File Offset: 0x002B61CC
		public new static vtkRandomPool New()
		{
			vtkRandomPool result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomPool.vtkRandomPool_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EACD RID: 125645 RVA: 0x002B8020 File Offset: 0x002B6220
		public vtkRandomPool() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRandomPool.vtkRandomPool_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EACE RID: 125646 RVA: 0x002B8064 File Offset: 0x002B6264
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EACF RID: 125647
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_GeneratePool_01(HandleRef pThis);

		/// <summary>
		/// These methods provide access to the raw random pool as a double
		/// array. The size of the array is Size*NumberOfComponents. Each x value
		/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
		/// (a modified time for generation is maintained). Also a method is
		/// available for getting the value at the ith pool position and compNum
		/// component. Finally, note that the GetValue() method uses modulo
		/// reduction to ensure that the request remains inside of the pool. Two
		/// forms are provided, the first assumes NumberOfComponents=1; the second
		/// allows access to a particular component. The GetPool() and GetValue()
		/// methods should only be called after GeneratePool() has been invoked;
		/// </summary>
		// Token: 0x0601EAD0 RID: 125648 RVA: 0x002B8070 File Offset: 0x002B6270
		public IntPtr GeneratePool()
		{
			return vtkRandomPool.vtkRandomPool_GeneratePool_01(base.GetCppThis());
		}

		// Token: 0x0601EAD1 RID: 125649
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetChunkSize_02(HandleRef pThis);

		/// <summary>
		/// Specify the work chunk size at which point multithreading kicks in. For small
		/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
		/// vtkMultiThreader.
		/// </summary>
		// Token: 0x0601EAD2 RID: 125650 RVA: 0x002B8090 File Offset: 0x002B6290
		public virtual long GetChunkSize()
		{
			return vtkRandomPool.vtkRandomPool_GetChunkSize_02(base.GetCppThis());
		}

		// Token: 0x0601EAD3 RID: 125651
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetChunkSizeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the work chunk size at which point multithreading kicks in. For small
		/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
		/// vtkMultiThreader.
		/// </summary>
		// Token: 0x0601EAD4 RID: 125652 RVA: 0x002B80B0 File Offset: 0x002B62B0
		public virtual long GetChunkSizeMaxValue()
		{
			return vtkRandomPool.vtkRandomPool_GetChunkSizeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x0601EAD5 RID: 125653
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetChunkSizeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Specify the work chunk size at which point multithreading kicks in. For small
		/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
		/// vtkMultiThreader.
		/// </summary>
		// Token: 0x0601EAD6 RID: 125654 RVA: 0x002B80D0 File Offset: 0x002B62D0
		public virtual long GetChunkSizeMinValue()
		{
			return vtkRandomPool.vtkRandomPool_GetChunkSizeMinValue_04(base.GetCppThis());
		}

		// Token: 0x0601EAD7 RID: 125655
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetNumberOfComponents_05(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the number of components in the pool. This is a
		/// convenience capability and can be used to interface with
		/// vtkDataArrays. By default the number of components is =1.
		/// </summary>
		// Token: 0x0601EAD8 RID: 125656 RVA: 0x002B80F0 File Offset: 0x002B62F0
		public virtual long GetNumberOfComponents()
		{
			return vtkRandomPool.vtkRandomPool_GetNumberOfComponents_05(base.GetCppThis());
		}

		// Token: 0x0601EAD9 RID: 125657
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetNumberOfComponentsMaxValue_06(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the number of components in the pool. This is a
		/// convenience capability and can be used to interface with
		/// vtkDataArrays. By default the number of components is =1.
		/// </summary>
		// Token: 0x0601EADA RID: 125658 RVA: 0x002B8110 File Offset: 0x002B6310
		public virtual long GetNumberOfComponentsMaxValue()
		{
			return vtkRandomPool.vtkRandomPool_GetNumberOfComponentsMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0601EADB RID: 125659
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetNumberOfComponentsMinValue_07(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the number of components in the pool. This is a
		/// convenience capability and can be used to interface with
		/// vtkDataArrays. By default the number of components is =1.
		/// </summary>
		// Token: 0x0601EADC RID: 125660 RVA: 0x002B8130 File Offset: 0x002B6330
		public virtual long GetNumberOfComponentsMinValue()
		{
			return vtkRandomPool.vtkRandomPool_GetNumberOfComponentsMinValue_07(base.GetCppThis());
		}

		// Token: 0x0601EADD RID: 125661
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EADE RID: 125662 RVA: 0x002B8150 File Offset: 0x002B6350
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRandomPool.vtkRandomPool_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601EADF RID: 125663
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EAE0 RID: 125664 RVA: 0x002B8170 File Offset: 0x002B6370
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRandomPool.vtkRandomPool_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601EAE1 RID: 125665
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_GetPool_10(HandleRef pThis);

		/// <summary>
		/// These methods provide access to the raw random pool as a double
		/// array. The size of the array is Size*NumberOfComponents. Each x value
		/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
		/// (a modified time for generation is maintained). Also a method is
		/// available for getting the value at the ith pool position and compNum
		/// component. Finally, note that the GetValue() method uses modulo
		/// reduction to ensure that the request remains inside of the pool. Two
		/// forms are provided, the first assumes NumberOfComponents=1; the second
		/// allows access to a particular component. The GetPool() and GetValue()
		/// methods should only be called after GeneratePool() has been invoked;
		/// </summary>
		// Token: 0x0601EAE2 RID: 125666 RVA: 0x002B818C File Offset: 0x002B638C
		public IntPtr GetPool()
		{
			return vtkRandomPool.vtkRandomPool_GetPool_10(base.GetCppThis());
		}

		// Token: 0x0601EAE3 RID: 125667
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_GetSequence_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the random sequence generator used to produce the random pool.
		/// By default vtkMersenneTwister is used.
		/// </summary>
		// Token: 0x0601EAE4 RID: 125668 RVA: 0x002B81AC File Offset: 0x002B63AC
		public virtual vtkRandomSequence GetSequence()
		{
			vtkRandomSequence vtkRandomSequence = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomPool.vtkRandomPool_GetSequence_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomSequence = (vtkRandomSequence)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomSequence.Register(null);
				}
			}
			return vtkRandomSequence;
		}

		// Token: 0x0601EAE5 RID: 125669
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetSize_12(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the size of the pool. The size must be specified
		/// before invoking GeneratePool(). Note the number of components will
		/// affect the total size (allocated memory is Size*NumberOfComponents).
		/// </summary>
		// Token: 0x0601EAE6 RID: 125670 RVA: 0x002B821C File Offset: 0x002B641C
		public virtual long GetSize()
		{
			return vtkRandomPool.vtkRandomPool_GetSize_12(base.GetCppThis());
		}

		// Token: 0x0601EAE7 RID: 125671
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetSizeMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the size of the pool. The size must be specified
		/// before invoking GeneratePool(). Note the number of components will
		/// affect the total size (allocated memory is Size*NumberOfComponents).
		/// </summary>
		// Token: 0x0601EAE8 RID: 125672 RVA: 0x002B823C File Offset: 0x002B643C
		public virtual long GetSizeMaxValue()
		{
			return vtkRandomPool.vtkRandomPool_GetSizeMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0601EAE9 RID: 125673
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetSizeMinValue_14(HandleRef pThis);

		/// <summary>
		/// Methods to set and get the size of the pool. The size must be specified
		/// before invoking GeneratePool(). Note the number of components will
		/// affect the total size (allocated memory is Size*NumberOfComponents).
		/// </summary>
		// Token: 0x0601EAEA RID: 125674 RVA: 0x002B825C File Offset: 0x002B645C
		public virtual long GetSizeMinValue()
		{
			return vtkRandomPool.vtkRandomPool_GetSizeMinValue_14(base.GetCppThis());
		}

		// Token: 0x0601EAEB RID: 125675
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomPool_GetTotalSize_15(HandleRef pThis);

		/// <summary>
		/// This convenience method returns the total size of the memory pool, i.e.,
		/// Size*NumberOfComponents.
		/// </summary>
		// Token: 0x0601EAEC RID: 125676 RVA: 0x002B827C File Offset: 0x002B647C
		public long GetTotalSize()
		{
			return vtkRandomPool.vtkRandomPool_GetTotalSize_15(base.GetCppThis());
		}

		// Token: 0x0601EAED RID: 125677
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomPool_GetValue_16(HandleRef pThis, long i);

		/// <summary>
		/// These methods provide access to the raw random pool as a double
		/// array. The size of the array is Size*NumberOfComponents. Each x value
		/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
		/// (a modified time for generation is maintained). Also a method is
		/// available for getting the value at the ith pool position and compNum
		/// component. Finally, note that the GetValue() method uses modulo
		/// reduction to ensure that the request remains inside of the pool. Two
		/// forms are provided, the first assumes NumberOfComponents=1; the second
		/// allows access to a particular component. The GetPool() and GetValue()
		/// methods should only be called after GeneratePool() has been invoked;
		/// </summary>
		// Token: 0x0601EAEE RID: 125678 RVA: 0x002B829C File Offset: 0x002B649C
		public double GetValue(long i)
		{
			return vtkRandomPool.vtkRandomPool_GetValue_16(base.GetCppThis(), i);
		}

		// Token: 0x0601EAEF RID: 125679
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomPool_GetValue_17(HandleRef pThis, long i, int compNum);

		/// <summary>
		/// These methods provide access to the raw random pool as a double
		/// array. The size of the array is Size*NumberOfComponents. Each x value
		/// ranges between (0&lt;=x&lt;=1). The class will generate the pool as necessary
		/// (a modified time for generation is maintained). Also a method is
		/// available for getting the value at the ith pool position and compNum
		/// component. Finally, note that the GetValue() method uses modulo
		/// reduction to ensure that the request remains inside of the pool. Two
		/// forms are provided, the first assumes NumberOfComponents=1; the second
		/// allows access to a particular component. The GetPool() and GetValue()
		/// methods should only be called after GeneratePool() has been invoked;
		/// </summary>
		// Token: 0x0601EAF0 RID: 125680 RVA: 0x002B82BC File Offset: 0x002B64BC
		public double GetValue(long i, int compNum)
		{
			return vtkRandomPool.vtkRandomPool_GetValue_17(base.GetCppThis(), i, compNum);
		}

		// Token: 0x0601EAF1 RID: 125681
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomPool_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EAF2 RID: 125682 RVA: 0x002B82E0 File Offset: 0x002B64E0
		public override int IsA(string type)
		{
			return vtkRandomPool.vtkRandomPool_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x0601EAF3 RID: 125683
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomPool_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EAF4 RID: 125684 RVA: 0x002B8300 File Offset: 0x002B6500
		public new static int IsTypeOf(string type)
		{
			return vtkRandomPool.vtkRandomPool_IsTypeOf_19(type);
		}

		// Token: 0x0601EAF5 RID: 125685
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EAF6 RID: 125686 RVA: 0x002B831C File Offset: 0x002B651C
		public new vtkRandomPool NewInstance()
		{
			vtkRandomPool result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomPool.vtkRandomPool_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EAF7 RID: 125687
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_PopulateDataArray_22(HandleRef pThis, HandleRef da, double minRange, double maxRange);

		/// <summary>
		/// Methods to populate data arrays of various types with values within a
		/// specified (min,max) range. Note that compNumber is used to specify the
		/// range for a particular component; otherwise all generated components are
		/// within the (min,max) range specified. (Thus it is possible to make
		/// multiple calls to generate random numbers for each component with
		/// different ranges.) Internally the type of the data array passed in is
		/// used to cast to the appropriate type. Also the size and number of
		/// components of the vtkDataArray controls the total number of random
		/// numbers generated; so the input data array should be pre-allocated with
		/// (SetNumberOfComponents, SetNumberOfTuples).
		/// </summary>
		// Token: 0x0601EAF8 RID: 125688 RVA: 0x002B8378 File Offset: 0x002B6578
		public void PopulateDataArray(vtkDataArray da, double minRange, double maxRange)
		{
			vtkRandomPool.vtkRandomPool_PopulateDataArray_22(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis(), minRange, maxRange);
		}

		// Token: 0x0601EAF9 RID: 125689
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_PopulateDataArray_23(HandleRef pThis, HandleRef da, int compNumber, double minRange, double maxRange);

		/// <summary>
		/// Methods to populate data arrays of various types with values within a
		/// specified (min,max) range. Note that compNumber is used to specify the
		/// range for a particular component; otherwise all generated components are
		/// within the (min,max) range specified. (Thus it is possible to make
		/// multiple calls to generate random numbers for each component with
		/// different ranges.) Internally the type of the data array passed in is
		/// used to cast to the appropriate type. Also the size and number of
		/// components of the vtkDataArray controls the total number of random
		/// numbers generated; so the input data array should be pre-allocated with
		/// (SetNumberOfComponents, SetNumberOfTuples).
		/// </summary>
		// Token: 0x0601EAFA RID: 125690 RVA: 0x002B83AC File Offset: 0x002B65AC
		public void PopulateDataArray(vtkDataArray da, int compNumber, double minRange, double maxRange)
		{
			vtkRandomPool.vtkRandomPool_PopulateDataArray_23(base.GetCppThis(), (da == null) ? default(HandleRef) : da.GetCppThis(), compNumber, minRange, maxRange);
		}

		// Token: 0x0601EAFB RID: 125691
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomPool_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information, and printing.
		/// </summary>
		// Token: 0x0601EAFC RID: 125692 RVA: 0x002B83E0 File Offset: 0x002B65E0
		public new static vtkRandomPool SafeDownCast(vtkObjectBase o)
		{
			vtkRandomPool vtkRandomPool = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomPool.vtkRandomPool_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomPool = (vtkRandomPool)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomPool.Register(null);
				}
			}
			return vtkRandomPool;
		}

		// Token: 0x0601EAFD RID: 125693
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_SetChunkSize_25(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the work chunk size at which point multithreading kicks in. For small
		/// memory pools &lt; ChunkSize, no threading is used. Larger pools are computed using
		/// vtkMultiThreader.
		/// </summary>
		// Token: 0x0601EAFE RID: 125694 RVA: 0x002B845F File Offset: 0x002B665F
		public virtual void SetChunkSize(long _arg)
		{
			vtkRandomPool.vtkRandomPool_SetChunkSize_25(base.GetCppThis(), _arg);
		}

		// Token: 0x0601EAFF RID: 125695
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_SetNumberOfComponents_26(HandleRef pThis, long _arg);

		/// <summary>
		/// Methods to set and get the number of components in the pool. This is a
		/// convenience capability and can be used to interface with
		/// vtkDataArrays. By default the number of components is =1.
		/// </summary>
		// Token: 0x0601EB00 RID: 125696 RVA: 0x002B846F File Offset: 0x002B666F
		public virtual void SetNumberOfComponents(long _arg)
		{
			vtkRandomPool.vtkRandomPool_SetNumberOfComponents_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0601EB01 RID: 125697
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_SetSequence_27(HandleRef pThis, HandleRef seq);

		/// <summary>
		/// Specify the random sequence generator used to produce the random pool.
		/// By default vtkMersenneTwister is used.
		/// </summary>
		// Token: 0x0601EB02 RID: 125698 RVA: 0x002B8480 File Offset: 0x002B6680
		public virtual void SetSequence(vtkRandomSequence seq)
		{
			vtkRandomPool.vtkRandomPool_SetSequence_27(base.GetCppThis(), (seq == null) ? default(HandleRef) : seq.GetCppThis());
		}

		// Token: 0x0601EB03 RID: 125699
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomPool_SetSize_28(HandleRef pThis, long _arg);

		/// <summary>
		/// Methods to set and get the size of the pool. The size must be specified
		/// before invoking GeneratePool(). Note the number of components will
		/// affect the total size (allocated memory is Size*NumberOfComponents).
		/// </summary>
		// Token: 0x0601EB04 RID: 125700 RVA: 0x002B84AF File Offset: 0x002B66AF
		public virtual void SetSize(long _arg)
		{
			vtkRandomPool.vtkRandomPool_SetSize_28(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DA RID: 8410
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomPool";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020DB RID: 8411
		public new static readonly string MRClassNameKey = "class vtkRandomPool";
	}
}
