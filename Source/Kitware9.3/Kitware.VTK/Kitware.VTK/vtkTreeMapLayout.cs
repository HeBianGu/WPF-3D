using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeMapLayout
	/// </summary>
	/// <remarks>
	///    layout a vtkTree into a tree map
	///
	///
	/// vtkTreeMapLayout assigns rectangular regions to each vertex in the tree,
	/// creating a tree map.  The data is added as a data array with four
	/// components per tuple representing the location and size of the
	/// rectangle using the format (Xmin, Xmax, Ymin, Ymax).
	///
	/// This algorithm relies on a helper class to perform the actual layout.
	/// This helper class is a subclass of vtkTreeMapLayoutStrategy.
	///
	/// @par Thanks:
	/// Thanks to Brian Wylie and Ken Moreland from Sandia National Laboratories
	/// for help developing this class.
	///
	/// @par Thanks:
	/// Tree map concept comes from:
	/// Shneiderman, B. 1992. Tree visualization with tree-maps: 2-d space-filling approach.
	/// ACM Trans. Graph. 11, 1 (Jan. 1992), 92-99.
	/// </remarks>
	// Token: 0x020002A2 RID: 674
	public class vtkTreeMapLayout : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007990 RID: 31120 RVA: 0x000AF2E3 File Offset: 0x000AD4E3
		static vtkTreeMapLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007991 RID: 31121 RVA: 0x000AF30B File Offset: 0x000AD50B
		public vtkTreeMapLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007992 RID: 31122
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007993 RID: 31123 RVA: 0x000AF31C File Offset: 0x000AD51C
		public new static vtkTreeMapLayout New()
		{
			vtkTreeMapLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007994 RID: 31124 RVA: 0x000AF370 File Offset: 0x000AD570
		public vtkTreeMapLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeMapLayout.vtkTreeMapLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007995 RID: 31125 RVA: 0x000AF3B4 File Offset: 0x000AD5B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007996 RID: 31126
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayout_FindVertex_01(HandleRef pThis, IntPtr pnt, IntPtr binfo);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// </summary>
		// Token: 0x06007997 RID: 31127 RVA: 0x000AF3C0 File Offset: 0x000AD5C0
		public long FindVertex(IntPtr pnt, IntPtr binfo)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_FindVertex_01(base.GetCppThis(), pnt, binfo);
		}

		// Token: 0x06007998 RID: 31128
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapLayout_GetBoundingBox_02(HandleRef pThis, long id, IntPtr binfo);

		/// <summary>
		/// Return the min and max 2D points of the
		/// vertex's bounding box
		/// </summary>
		// Token: 0x06007999 RID: 31129 RVA: 0x000AF3E1 File Offset: 0x000AD5E1
		public void GetBoundingBox(long id, IntPtr binfo)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_GetBoundingBox_02(base.GetCppThis(), id, binfo);
		}

		// Token: 0x0600799A RID: 31130
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayout_GetLayoutStrategy_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x0600799B RID: 31131 RVA: 0x000AF3F4 File Offset: 0x000AD5F4
		public virtual vtkTreeMapLayoutStrategy GetLayoutStrategy()
		{
			vtkTreeMapLayoutStrategy vtkTreeMapLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_GetLayoutStrategy_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayoutStrategy = (vtkTreeMapLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayoutStrategy.Register(null);
				}
			}
			return vtkTreeMapLayoutStrategy;
		}

		// Token: 0x0600799C RID: 31132
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTreeMapLayout_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Get the modification time of the layout algorithm.
		/// </summary>
		// Token: 0x0600799D RID: 31133 RVA: 0x000AF464 File Offset: 0x000AD664
		public override ulong GetMTime()
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x0600799E RID: 31134
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayout_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600799F RID: 31135 RVA: 0x000AF484 File Offset: 0x000AD684
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060079A0 RID: 31136
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeMapLayout_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079A1 RID: 31137 RVA: 0x000AF4A4 File Offset: 0x000AD6A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060079A2 RID: 31138
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayout_GetRectanglesFieldName_07(HandleRef pThis);

		/// <summary>
		/// The field name to use for storing the rectangles for each vertex.
		/// The rectangles are stored in a quadruple float array
		/// (minX, maxX, minY, maxY).
		/// </summary>
		// Token: 0x060079A3 RID: 31139 RVA: 0x000AF4C0 File Offset: 0x000AD6C0
		public virtual string GetRectanglesFieldName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeMapLayout.vtkTreeMapLayout_GetRectanglesFieldName_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060079A4 RID: 31140
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapLayout_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079A5 RID: 31141 RVA: 0x000AF4FC File Offset: 0x000AD6FC
		public override int IsA(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060079A6 RID: 31142
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeMapLayout_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079A7 RID: 31143 RVA: 0x000AF51C File Offset: 0x000AD71C
		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapLayout.vtkTreeMapLayout_IsTypeOf_09(type);
		}

		// Token: 0x060079A8 RID: 31144
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayout_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079A9 RID: 31145 RVA: 0x000AF538 File Offset: 0x000AD738
		public new vtkTreeMapLayout NewInstance()
		{
			vtkTreeMapLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060079AA RID: 31146
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeMapLayout_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060079AB RID: 31147 RVA: 0x000AF594 File Offset: 0x000AD794
		public new static vtkTreeMapLayout SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapLayout vtkTreeMapLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeMapLayout.vtkTreeMapLayout_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapLayout = (vtkTreeMapLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapLayout.Register(null);
				}
			}
			return vtkTreeMapLayout;
		}

		// Token: 0x060079AC RID: 31148
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapLayout_SetLayoutStrategy_13(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x060079AD RID: 31149 RVA: 0x000AF614 File Offset: 0x000AD814
		public void SetLayoutStrategy(vtkTreeMapLayoutStrategy strategy)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetLayoutStrategy_13(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x060079AE RID: 31150
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapLayout_SetRectanglesFieldName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field name to use for storing the rectangles for each vertex.
		/// The rectangles are stored in a quadruple float array
		/// (minX, maxX, minY, maxY).
		/// </summary>
		// Token: 0x060079AF RID: 31151 RVA: 0x000AF643 File Offset: 0x000AD843
		public virtual void SetRectanglesFieldName(string _arg)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetRectanglesFieldName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060079B0 RID: 31152
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeMapLayout_SetSizeArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for the size of each vertex.
		/// </summary>
		// Token: 0x060079B1 RID: 31153 RVA: 0x000AF653 File Offset: 0x000AD853
		public virtual void SetSizeArrayName(string name)
		{
			vtkTreeMapLayout.vtkTreeMapLayout_SetSizeArrayName_15(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A54 RID: 2644
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A55 RID: 2645
		public new static readonly string MRClassNameKey = "class vtkTreeMapLayout";
	}
}
