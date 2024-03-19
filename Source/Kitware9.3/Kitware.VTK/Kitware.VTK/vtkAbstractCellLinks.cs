using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractCellLinks
	/// </summary>
	/// <remarks>
	///    an abstract base class for classes that build
	/// topological links from points to cells
	///
	/// vtkAbstractCellLinks is a family of supplemental objects to vtkCellArray and
	/// vtkCellTypes, enabling fast access from points to the cells using the
	/// points. vtkAbstractCellLinks is an array of links, each link representing a
	/// list of cell ids using a particular point. The information provided by
	/// this object can be used to determine neighbors and construct other local
	/// topological information.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellLinks vtkStaticCellLinks vtkStaticCellLinksTemplate
	/// </seealso>
	// Token: 0x020009EF RID: 2543
	public abstract class vtkAbstractCellLinks : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A6AD RID: 108205 RVA: 0x0024AF92 File Offset: 0x00249192
		static vtkAbstractCellLinks()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractCellLinks.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractCellLinks"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6AE RID: 108206 RVA: 0x0024AFBA File Offset: 0x002491BA
		public vtkAbstractCellLinks(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A6AF RID: 108207 RVA: 0x0024AFC8 File Offset: 0x002491C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A6B0 RID: 108208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_BuildLinks_01(HandleRef pThis);

		/// <summary>
		/// Build the link list array from the input dataset.
		/// </summary>
		// Token: 0x0601A6B1 RID: 108209 RVA: 0x0024AFD3 File Offset: 0x002491D3
		public virtual void BuildLinks()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_BuildLinks_01(base.GetCppThis());
		}

		// Token: 0x0601A6B2 RID: 108210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLinks_ComputeType_02(long maxPtId, long maxCellId, HandleRef ca);

		/// <summary>
		/// Based on the input (i.e., number of points, number of cells, and length
		/// of connectivity array) this helper method returns the integral type to
		/// use when instantiating cell link-related classes in order to properly
		/// represent the data.  The return value is one of the types
		/// defined in the enum CellLinksType enum defined previously. Subclasses
		/// may choose to instantiate themselves with different integral types for
		/// performance and/or memory reasons. This method is useful when instantiating
		/// a vtkStaticCellLinksTemplate; when instantiating a vtkCellLinks the class
		/// is hardwired for vtkIdType.
		/// </summary>
		// Token: 0x0601A6B3 RID: 108211 RVA: 0x0024AFE4 File Offset: 0x002491E4
		public static int ComputeType(long maxPtId, long maxCellId, vtkCellArray ca)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_ComputeType_02(maxPtId, maxCellId, (ca == null) ? default(HandleRef) : ca.GetCppThis());
		}

		// Token: 0x0601A6B4 RID: 108212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLinks_ComputeType_03(long maxPtId, long maxCellId, long connectivitySize);

		/// <summary>
		/// Based on the input (i.e., number of points, number of cells, and length
		/// of connectivity array) this helper method returns the integral type to
		/// use when instantiating cell link-related classes in order to properly
		/// represent the data.  The return value is one of the types
		/// defined in the enum CellLinksType enum defined previously. Subclasses
		/// may choose to instantiate themselves with different integral types for
		/// performance and/or memory reasons. This method is useful when instantiating
		/// a vtkStaticCellLinksTemplate; when instantiating a vtkCellLinks the class
		/// is hardwired for vtkIdType.
		/// </summary>
		// Token: 0x0601A6B5 RID: 108213 RVA: 0x0024B014 File Offset: 0x00249214
		public static int ComputeType(long maxPtId, long maxCellId, long connectivitySize)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_ComputeType_03(maxPtId, maxCellId, connectivitySize);
		}

		// Token: 0x0601A6B6 RID: 108214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_DeepCopy_04(HandleRef pThis, HandleRef src);

		/// <summary>
		/// Standard DeepCopy method.  Since this object contains no reference
		/// to other objects, there is no ShallowCopy.
		/// </summary>
		// Token: 0x0601A6B7 RID: 108215 RVA: 0x0024B030 File Offset: 0x00249230
		public virtual void DeepCopy(vtkAbstractCellLinks src)
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_DeepCopy_04(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		// Token: 0x0601A6B8 RID: 108216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkAbstractCellLinks_GetActualMemorySize_05(HandleRef pThis);

		/// <summary>
		/// Return the memory in kibibytes (1024 bytes) consumed by this cell links array.
		/// Used to support streaming and reading/writing data. The value
		/// returned is guaranteed to be greater than or equal to the memory
		/// required to actually represent the data represented by this object.
		/// The information returned is valid only after the pipeline has
		/// been updated.
		/// </summary>
		// Token: 0x0601A6B9 RID: 108217 RVA: 0x0024B060 File Offset: 0x00249260
		public virtual uint GetActualMemorySize()
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetActualMemorySize_05(base.GetCppThis());
		}

		// Token: 0x0601A6BA RID: 108218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAbstractCellLinks_GetBuildTime_06(HandleRef pThis);

		/// <summary>
		/// Return the time of the last data structure build.
		/// </summary>
		// Token: 0x0601A6BB RID: 108219 RVA: 0x0024B080 File Offset: 0x00249280
		public virtual ulong GetBuildTime()
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetBuildTime_06(base.GetCppThis());
		}

		// Token: 0x0601A6BC RID: 108220
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractCellLinks_GetDataSet_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the points/cells defining this dataset.
		/// </summary>
		// Token: 0x0601A6BD RID: 108221 RVA: 0x0024B0A0 File Offset: 0x002492A0
		public virtual vtkDataSet GetDataSet()
		{
			vtkDataSet vtkDataSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractCellLinks.vtkAbstractCellLinks_GetDataSet_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataSet = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataSet.Register(null);
				}
			}
			return vtkDataSet;
		}

		// Token: 0x0601A6BE RID: 108222
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLinks_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6BF RID: 108223 RVA: 0x0024B110 File Offset: 0x00249310
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A6C0 RID: 108224
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractCellLinks_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6C1 RID: 108225 RVA: 0x0024B130 File Offset: 0x00249330
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601A6C2 RID: 108226
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractCellLinks_GetSequentialProcessing_10(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the link building
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x0601A6C3 RID: 108227 RVA: 0x0024B14C File Offset: 0x0024934C
		public virtual bool GetSequentialProcessing()
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetSequentialProcessing_10(base.GetCppThis()) != 0;
		}

		// Token: 0x0601A6C4 RID: 108228
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLinks_GetType_11(HandleRef pThis);

		/// <summary>
		/// Return the type of locator (see enum above).
		/// </summary>
		// Token: 0x0601A6C5 RID: 108229 RVA: 0x0024B174 File Offset: 0x00249374
		public virtual int GetTypeWrapper()
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_GetType_11(base.GetCppThis());
		}

		// Token: 0x0601A6C6 RID: 108230
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_Initialize_12(HandleRef pThis);

		/// <summary>
		/// Release memory and revert to empty state.
		/// </summary>
		// Token: 0x0601A6C7 RID: 108231 RVA: 0x0024B193 File Offset: 0x00249393
		public virtual void Initialize()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_Initialize_12(base.GetCppThis());
		}

		// Token: 0x0601A6C8 RID: 108232
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLinks_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6C9 RID: 108233 RVA: 0x0024B1A4 File Offset: 0x002493A4
		public override int IsA(string type)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601A6CA RID: 108234
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractCellLinks_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6CB RID: 108235 RVA: 0x0024B1C4 File Offset: 0x002493C4
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_IsTypeOf_14(type);
		}

		// Token: 0x0601A6CC RID: 108236
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractCellLinks_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6CD RID: 108237 RVA: 0x0024B1E0 File Offset: 0x002493E0
		public new vtkAbstractCellLinks NewInstance()
		{
			vtkAbstractCellLinks result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractCellLinks.vtkAbstractCellLinks_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A6CE RID: 108238
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_Reset_16(HandleRef pThis);

		/// <summary>
		/// Reset to a state of no entries without freeing the memory.
		/// </summary>
		// Token: 0x0601A6CF RID: 108239 RVA: 0x0024B23A File Offset: 0x0024943A
		public virtual void Reset()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_Reset_16(base.GetCppThis());
		}

		// Token: 0x0601A6D0 RID: 108240
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractCellLinks_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard type and print methods.
		/// </summary>
		// Token: 0x0601A6D1 RID: 108241 RVA: 0x0024B24C File Offset: 0x0024944C
		public new static vtkAbstractCellLinks SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractCellLinks vtkAbstractCellLinks = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractCellLinks.vtkAbstractCellLinks_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLinks = (vtkAbstractCellLinks)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLinks.Register(null);
				}
			}
			return vtkAbstractCellLinks;
		}

		// Token: 0x0601A6D2 RID: 108242
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_SelectCells_18(HandleRef pThis, IntPtr minMaxDegree, IntPtr cellSelection);

		/// <summary>
		/// Select all cells with a point degree in the range [minDegree,maxDegree).
		/// The degree is the number of cells using a point. The selection is
		/// indicated through the provided unsigned char array, with a non-zero
		/// value indicates selection. The memory allocated for cellSelection must
		/// be the maximum cell id referenced in the links.
		/// </summary>
		// Token: 0x0601A6D3 RID: 108243 RVA: 0x0024B2CB File Offset: 0x002494CB
		public virtual void SelectCells(IntPtr minMaxDegree, IntPtr cellSelection)
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_SelectCells_18(base.GetCppThis(), minMaxDegree, cellSelection);
		}

		// Token: 0x0601A6D4 RID: 108244
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_SequentialProcessingOff_19(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the link building
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x0601A6D5 RID: 108245 RVA: 0x0024B2DC File Offset: 0x002494DC
		public virtual void SequentialProcessingOff()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_SequentialProcessingOff_19(base.GetCppThis());
		}

		// Token: 0x0601A6D6 RID: 108246
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_SequentialProcessingOn_20(HandleRef pThis);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the link building
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x0601A6D7 RID: 108247 RVA: 0x0024B2EB File Offset: 0x002494EB
		public virtual void SequentialProcessingOn()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_SequentialProcessingOn_20(base.GetCppThis());
		}

		// Token: 0x0601A6D8 RID: 108248
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_SetDataSet_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the points/cells defining this dataset.
		/// </summary>
		// Token: 0x0601A6D9 RID: 108249 RVA: 0x0024B2FC File Offset: 0x002494FC
		public virtual void SetDataSet(vtkDataSet arg0)
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_SetDataSet_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A6DA RID: 108250
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_SetSequentialProcessing_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Force sequential processing (i.e. single thread) of the link building
		/// process. By default, sequential processing is off. Note this flag only
		/// applies if the class has been compiled with VTK_SMP_IMPLEMENTATION_TYPE
		/// set to something other than Sequential. (If set to Sequential, then the
		/// filter always runs in serial mode.) This flag is typically used for
		/// benchmarking purposes.
		/// </summary>
		// Token: 0x0601A6DB RID: 108251 RVA: 0x0024B32B File Offset: 0x0024952B
		public virtual void SetSequentialProcessing(bool _arg)
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_SetSequentialProcessing_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601A6DC RID: 108252
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractCellLinks_Squeeze_23(HandleRef pThis);

		/// <summary>
		/// Reclaim any unused memory.
		/// </summary>
		// Token: 0x0601A6DD RID: 108253 RVA: 0x0024B343 File Offset: 0x00249543
		public virtual void Squeeze()
		{
			vtkAbstractCellLinks.vtkAbstractCellLinks_Squeeze_23(base.GetCppThis());
		}

		// Token: 0x0601A6DE RID: 108254
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractCellLinks_UsesGarbageCollector_24(HandleRef pThis);

		/// <summary>
		/// Handle the dataset &lt;-&gt; Links loop.
		/// </summary>
		// Token: 0x0601A6DF RID: 108255 RVA: 0x0024B354 File Offset: 0x00249554
		public override bool UsesGarbageCollector()
		{
			return vtkAbstractCellLinks.vtkAbstractCellLinks_UsesGarbageCollector_24(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAE RID: 7342
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractCellLinks";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CAF RID: 7343
		public new static readonly string MRClassNameKey = "class vtkAbstractCellLinks";

		/// <summary>
		/// Standard DeepCopy method.  Since this object contains no reference
		/// to other objects, there is no ShallowCopy.
		/// </summary>
		// Token: 0x020009F0 RID: 2544
		public enum CellLinksTypes
		{
			/// <summary>enum member</summary>
			// Token: 0x04001CB1 RID: 7345
			CELL_LINKS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001CB2 RID: 7346
			LINKS_NOT_DEFINED = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001CB3 RID: 7347
			STATIC_CELL_LINKS_IDTYPE = 4,
			/// <summary>enum member</summary>
			// Token: 0x04001CB4 RID: 7348
			STATIC_CELL_LINKS_SPECIALIZED,
			/// <summary>enum member</summary>
			// Token: 0x04001CB5 RID: 7349
			STATIC_CELL_LINKS_UINT = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001CB6 RID: 7350
			STATIC_CELL_LINKS_USHORT = 2
		}
	}
}
