using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCirclePackLayout
	/// </summary>
	/// <remarks>
	///    layout a vtkTree as a circle packing.
	///
	///
	/// vtkCirclePackLayout assigns circle shaped regions to each vertex
	/// in the tree, creating a circle packing layout.  The data is added
	/// as a data array with three components per tuple representing the
	/// center and radius of the circle using the format (Xcenter, Ycenter, Radius).
	///
	/// This algorithm relies on a helper class to perform the actual layout.
	/// This helper class is a subclass of vtkCirclePackLayoutStrategy.
	///
	/// An array by default called "size" can be attached to the input tree
	/// that specifies the size of each leaf node in the tree.  The filter will
	/// calculate the sizes of all interior nodes in the tree based on the sum
	/// of the leaf node sizes.  If no "size" array is given in the input vtkTree,
	/// a size of 1 is used for all leaf nodes to find the size of the interior nodes.
	///
	/// @par Thanks:
	/// Thanks to Thomas Otahal from Sandia National Laboratories
	/// for help developing this class.
	///
	/// </remarks>
	// Token: 0x02000284 RID: 644
	public class vtkCirclePackLayout : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007482 RID: 29826 RVA: 0x000A87B7 File Offset: 0x000A69B7
		static vtkCirclePackLayout()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCirclePackLayout.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCirclePackLayout"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007483 RID: 29827 RVA: 0x000A87DF File Offset: 0x000A69DF
		public vtkCirclePackLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007484 RID: 29828
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007485 RID: 29829 RVA: 0x000A87F0 File Offset: 0x000A69F0
		public new static vtkCirclePackLayout New()
		{
			vtkCirclePackLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayout.vtkCirclePackLayout_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007486 RID: 29830 RVA: 0x000A8844 File Offset: 0x000A6A44
		public vtkCirclePackLayout() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCirclePackLayout.vtkCirclePackLayout_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007487 RID: 29831 RVA: 0x000A8888 File Offset: 0x000A6A88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007488 RID: 29832
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackLayout_FindVertex_01(HandleRef pThis, IntPtr pnt, IntPtr cinfo);

		/// <summary>
		/// Returns the vertex id that contains pnt (or -1 if no one contains it)
		/// pnt[0] is x, and pnt[1] is y.
		/// If cinfo[3] is provided, then (Xcenter, Ycenter, Radius) of the circle
		/// containing pnt[2] will be returned.
		/// </summary>
		// Token: 0x06007489 RID: 29833 RVA: 0x000A8894 File Offset: 0x000A6A94
		public long FindVertex(IntPtr pnt, IntPtr cinfo)
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_FindVertex_01(base.GetCppThis(), pnt, cinfo);
		}

		// Token: 0x0600748A RID: 29834
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackLayout_GetBoundingCircle_02(HandleRef pThis, long id, IntPtr cinfo);

		/// <summary>
		/// Return the Xcenter, Ycenter, and Radius of the
		/// vertex's bounding circle
		/// </summary>
		// Token: 0x0600748B RID: 29835 RVA: 0x000A88B5 File Offset: 0x000A6AB5
		public void GetBoundingCircle(long id, IntPtr cinfo)
		{
			vtkCirclePackLayout.vtkCirclePackLayout_GetBoundingCircle_02(base.GetCppThis(), id, cinfo);
		}

		// Token: 0x0600748C RID: 29836
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayout_GetCirclesFieldName_03(HandleRef pThis);

		/// <summary>
		/// The field name to use for storing the circles for each vertex.
		/// The rectangles are stored in a triple float array
		/// (Xcenter, Ycenter, Radius).
		/// Default name is "circles"
		/// </summary>
		// Token: 0x0600748D RID: 29837 RVA: 0x000A88C8 File Offset: 0x000A6AC8
		public virtual string GetCirclesFieldName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCirclePackLayout.vtkCirclePackLayout_GetCirclesFieldName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600748E RID: 29838
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayout_GetLayoutStrategy_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x0600748F RID: 29839 RVA: 0x000A8904 File Offset: 0x000A6B04
		public virtual vtkCirclePackLayoutStrategy GetLayoutStrategy()
		{
			vtkCirclePackLayoutStrategy vtkCirclePackLayoutStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayout.vtkCirclePackLayout_GetLayoutStrategy_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCirclePackLayoutStrategy = (vtkCirclePackLayoutStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCirclePackLayoutStrategy.Register(null);
				}
			}
			return vtkCirclePackLayoutStrategy;
		}

		// Token: 0x06007490 RID: 29840
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkCirclePackLayout_GetMTime_05(HandleRef pThis);

		/// <summary>
		/// Get the modification time of the layout algorithm.
		/// </summary>
		// Token: 0x06007491 RID: 29841 RVA: 0x000A8974 File Offset: 0x000A6B74
		public override ulong GetMTime()
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_GetMTime_05(base.GetCppThis());
		}

		// Token: 0x06007492 RID: 29842
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackLayout_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007493 RID: 29843 RVA: 0x000A8994 File Offset: 0x000A6B94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06007494 RID: 29844
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCirclePackLayout_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007495 RID: 29845 RVA: 0x000A89B4 File Offset: 0x000A6BB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06007496 RID: 29846
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackLayout_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007497 RID: 29847 RVA: 0x000A89D0 File Offset: 0x000A6BD0
		public override int IsA(string type)
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06007498 RID: 29848
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCirclePackLayout_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007499 RID: 29849 RVA: 0x000A89F0 File Offset: 0x000A6BF0
		public new static int IsTypeOf(string type)
		{
			return vtkCirclePackLayout.vtkCirclePackLayout_IsTypeOf_09(type);
		}

		// Token: 0x0600749A RID: 29850
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayout_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600749B RID: 29851 RVA: 0x000A8A0C File Offset: 0x000A6C0C
		public new vtkCirclePackLayout NewInstance()
		{
			vtkCirclePackLayout result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayout.vtkCirclePackLayout_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600749C RID: 29852
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCirclePackLayout_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600749D RID: 29853 RVA: 0x000A8A68 File Offset: 0x000A6C68
		public new static vtkCirclePackLayout SafeDownCast(vtkObjectBase o)
		{
			vtkCirclePackLayout vtkCirclePackLayout = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCirclePackLayout.vtkCirclePackLayout_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCirclePackLayout = (vtkCirclePackLayout)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCirclePackLayout.Register(null);
				}
			}
			return vtkCirclePackLayout;
		}

		// Token: 0x0600749E RID: 29854
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackLayout_SetCirclesFieldName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The field name to use for storing the circles for each vertex.
		/// The rectangles are stored in a triple float array
		/// (Xcenter, Ycenter, Radius).
		/// Default name is "circles"
		/// </summary>
		// Token: 0x0600749F RID: 29855 RVA: 0x000A8AE7 File Offset: 0x000A6CE7
		public virtual void SetCirclesFieldName(string _arg)
		{
			vtkCirclePackLayout.vtkCirclePackLayout_SetCirclesFieldName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060074A0 RID: 29856
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackLayout_SetLayoutStrategy_14(HandleRef pThis, HandleRef strategy);

		/// <summary>
		/// The strategy to use when laying out the tree map.
		/// </summary>
		// Token: 0x060074A1 RID: 29857 RVA: 0x000A8AF8 File Offset: 0x000A6CF8
		public void SetLayoutStrategy(vtkCirclePackLayoutStrategy strategy)
		{
			vtkCirclePackLayout.vtkCirclePackLayout_SetLayoutStrategy_14(base.GetCppThis(), (strategy == null) ? default(HandleRef) : strategy.GetCppThis());
		}

		// Token: 0x060074A2 RID: 29858
		[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCirclePackLayout_SetSizeArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for the size of each vertex.
		/// Default name is "size".
		/// </summary>
		// Token: 0x060074A3 RID: 29859 RVA: 0x000A8B27 File Offset: 0x000A6D27
		public virtual void SetSizeArrayName(string name)
		{
			vtkCirclePackLayout.vtkCirclePackLayout_SetSizeArrayName_15(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A16 RID: 2582
		public new const string MRFullTypeName = "Kitware.VTK.vtkCirclePackLayout";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000A17 RID: 2583
		public new static readonly string MRClassNameKey = "class vtkCirclePackLayout";
	}
}
