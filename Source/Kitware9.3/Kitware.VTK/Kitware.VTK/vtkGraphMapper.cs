using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphMapper
	/// </summary>
	/// <remarks>
	///    map vtkGraph and derived
	/// classes to graphics primitives
	///
	///
	/// vtkGraphMapper is a mapper to map vtkGraph
	/// (and all derived classes) to graphics primitives.
	/// </remarks>
	// Token: 0x020007E2 RID: 2018
	public class vtkGraphMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014B88 RID: 84872 RVA: 0x001D5477 File Offset: 0x001D3677
		static vtkGraphMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014B89 RID: 84873 RVA: 0x001D549F File Offset: 0x001D369F
		public vtkGraphMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014B8A RID: 84874
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B8B RID: 84875 RVA: 0x001D54B0 File Offset: 0x001D36B0
		public new static vtkGraphMapper New()
		{
			vtkGraphMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014B8C RID: 84876 RVA: 0x001D5504 File Offset: 0x001D3704
		public vtkGraphMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphMapper.vtkGraphMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014B8D RID: 84877 RVA: 0x001D5548 File Offset: 0x001D3748
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014B8E RID: 84878
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_AddIconType_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type, int index);

		/// <summary>
		/// Associate the icon at index "index" in the vtkTexture to all vertices
		/// containing "type" as a value in the vertex attribute array specified by
		/// IconArrayName.
		/// </summary>
		// Token: 0x06014B8F RID: 84879 RVA: 0x001D5553 File Offset: 0x001D3753
		public void AddIconType(string type, int index)
		{
			vtkGraphMapper.vtkGraphMapper_AddIconType_01(base.GetCppThis(), type, index);
		}

		// Token: 0x06014B90 RID: 84880
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ClearIconTypes_02(HandleRef pThis);

		/// <summary>
		/// Clear all icon mappings.
		/// </summary>
		// Token: 0x06014B91 RID: 84881 RVA: 0x001D5564 File Offset: 0x001D3764
		public void ClearIconTypes()
		{
			vtkGraphMapper.vtkGraphMapper_ClearIconTypes_02(base.GetCppThis());
		}

		// Token: 0x06014B92 RID: 84882
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ColorEdgesOff_03(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06014B93 RID: 84883 RVA: 0x001D5573 File Offset: 0x001D3773
		public void ColorEdgesOff()
		{
			vtkGraphMapper.vtkGraphMapper_ColorEdgesOff_03(base.GetCppThis());
		}

		// Token: 0x06014B94 RID: 84884
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ColorEdgesOn_04(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06014B95 RID: 84885 RVA: 0x001D5582 File Offset: 0x001D3782
		public void ColorEdgesOn()
		{
			vtkGraphMapper.vtkGraphMapper_ColorEdgesOn_04(base.GetCppThis());
		}

		// Token: 0x06014B96 RID: 84886
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ColorVerticesOff_05(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06014B97 RID: 84887 RVA: 0x001D5591 File Offset: 0x001D3791
		public void ColorVerticesOff()
		{
			vtkGraphMapper.vtkGraphMapper_ColorVerticesOff_05(base.GetCppThis());
		}

		// Token: 0x06014B98 RID: 84888
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ColorVerticesOn_06(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06014B99 RID: 84889 RVA: 0x001D55A0 File Offset: 0x001D37A0
		public void ColorVerticesOn()
		{
			vtkGraphMapper.vtkGraphMapper_ColorVerticesOn_06(base.GetCppThis());
		}

		// Token: 0x06014B9A RID: 84890
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EdgeVisibilityOff_07(HandleRef pThis);

		/// <summary>
		/// Whether to show edges or not.  Default is on.
		/// </summary>
		// Token: 0x06014B9B RID: 84891 RVA: 0x001D55AF File Offset: 0x001D37AF
		public virtual void EdgeVisibilityOff()
		{
			vtkGraphMapper.vtkGraphMapper_EdgeVisibilityOff_07(base.GetCppThis());
		}

		// Token: 0x06014B9C RID: 84892
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EdgeVisibilityOn_08(HandleRef pThis);

		/// <summary>
		/// Whether to show edges or not.  Default is on.
		/// </summary>
		// Token: 0x06014B9D RID: 84893 RVA: 0x001D55BE File Offset: 0x001D37BE
		public virtual void EdgeVisibilityOn()
		{
			vtkGraphMapper.vtkGraphMapper_EdgeVisibilityOn_08(base.GetCppThis());
		}

		// Token: 0x06014B9E RID: 84894
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EnableEdgesByArrayOff_09(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable edges using array values.  Default is off.
		/// </summary>
		// Token: 0x06014B9F RID: 84895 RVA: 0x001D55CD File Offset: 0x001D37CD
		public virtual void EnableEdgesByArrayOff()
		{
			vtkGraphMapper.vtkGraphMapper_EnableEdgesByArrayOff_09(base.GetCppThis());
		}

		// Token: 0x06014BA0 RID: 84896
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EnableEdgesByArrayOn_10(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable edges using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BA1 RID: 84897 RVA: 0x001D55DC File Offset: 0x001D37DC
		public virtual void EnableEdgesByArrayOn()
		{
			vtkGraphMapper.vtkGraphMapper_EnableEdgesByArrayOn_10(base.GetCppThis());
		}

		// Token: 0x06014BA2 RID: 84898
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EnableVerticesByArrayOff_11(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable vertices using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BA3 RID: 84899 RVA: 0x001D55EB File Offset: 0x001D37EB
		public virtual void EnableVerticesByArrayOff()
		{
			vtkGraphMapper.vtkGraphMapper_EnableVerticesByArrayOff_11(base.GetCppThis());
		}

		// Token: 0x06014BA4 RID: 84900
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_EnableVerticesByArrayOn_12(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable vertices using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BA5 RID: 84901 RVA: 0x001D55FA File Offset: 0x001D37FA
		public virtual void EnableVerticesByArrayOn()
		{
			vtkGraphMapper.vtkGraphMapper_EnableVerticesByArrayOn_12(base.GetCppThis());
		}

		// Token: 0x06014BA6 RID: 84902
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetBounds_13(HandleRef pThis);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06014BA7 RID: 84903 RVA: 0x001D560C File Offset: 0x001D380C
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetBounds_13(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014BA8 RID: 84904
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_GetBounds_14(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Return bounding box (array of six doubles) of data expressed as
		/// (xmin,xmax, ymin,ymax, zmin,zmax).
		/// </summary>
		// Token: 0x06014BA9 RID: 84905 RVA: 0x001D5654 File Offset: 0x001D3854
		public override void GetBounds(IntPtr bounds)
		{
			vtkGraphMapper.vtkGraphMapper_GetBounds_14(base.GetCppThis(), bounds);
		}

		// Token: 0x06014BAA RID: 84906
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphMapper_GetColorEdges_15(HandleRef pThis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06014BAB RID: 84907 RVA: 0x001D5664 File Offset: 0x001D3864
		public bool GetColorEdges()
		{
			return vtkGraphMapper.vtkGraphMapper_GetColorEdges_15(base.GetCppThis()) != 0;
		}

		// Token: 0x06014BAC RID: 84908
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphMapper_GetColorVertices_16(HandleRef pThis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06014BAD RID: 84909 RVA: 0x001D568C File Offset: 0x001D388C
		public bool GetColorVertices()
		{
			return vtkGraphMapper.vtkGraphMapper_GetColorVertices_16(base.GetCppThis()) != 0;
		}

		// Token: 0x06014BAE RID: 84910
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetEdgeColorArrayName_17(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BAF RID: 84911 RVA: 0x001D56B4 File Offset: 0x001D38B4
		public string GetEdgeColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEdgeColorArrayName_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BB0 RID: 84912
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGraphMapper_GetEdgeLineWidth_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the edge line width
		/// </summary>
		// Token: 0x06014BB1 RID: 84913 RVA: 0x001D56F0 File Offset: 0x001D38F0
		public virtual float GetEdgeLineWidth()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEdgeLineWidth_18(base.GetCppThis());
		}

		// Token: 0x06014BB2 RID: 84914
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetEdgeLookupTable_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access to the lookup tables used by the vertex and edge mappers.
		/// </summary>
		// Token: 0x06014BB3 RID: 84915 RVA: 0x001D5710 File Offset: 0x001D3910
		public virtual vtkLookupTable GetEdgeLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetEdgeLookupTable_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x06014BB4 RID: 84916
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphMapper_GetEdgeVisibility_20(HandleRef pThis);

		/// <summary>
		/// Whether to show edges or not.  Default is on.
		/// </summary>
		// Token: 0x06014BB5 RID: 84917 RVA: 0x001D5780 File Offset: 0x001D3980
		public bool GetEdgeVisibility()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEdgeVisibility_20(base.GetCppThis()) != 0;
		}

		// Token: 0x06014BB6 RID: 84918
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphMapper_GetEnableEdgesByArray_21(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable edges using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BB7 RID: 84919 RVA: 0x001D57A8 File Offset: 0x001D39A8
		public virtual int GetEnableEdgesByArray()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEnableEdgesByArray_21(base.GetCppThis());
		}

		// Token: 0x06014BB8 RID: 84920
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphMapper_GetEnableVerticesByArray_22(HandleRef pThis);

		/// <summary>
		/// Whether to enable/disable vertices using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BB9 RID: 84921 RVA: 0x001D57C8 File Offset: 0x001D39C8
		public virtual int GetEnableVerticesByArray()
		{
			return vtkGraphMapper.vtkGraphMapper_GetEnableVerticesByArray_22(base.GetCppThis());
		}

		// Token: 0x06014BBA RID: 84922
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetEnabledEdgesArrayName_23(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BBB RID: 84923 RVA: 0x001D57E8 File Offset: 0x001D39E8
		public virtual string GetEnabledEdgesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEnabledEdgesArrayName_23(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BBC RID: 84924
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetEnabledVerticesArrayName_24(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BBD RID: 84925 RVA: 0x001D5824 File Offset: 0x001D3A24
		public virtual string GetEnabledVerticesArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetEnabledVerticesArrayName_24(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BBE RID: 84926
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetIconArrayName_25(HandleRef pThis);

		/// <summary>
		/// The array to use for assigning icons.
		/// </summary>
		// Token: 0x06014BBF RID: 84927 RVA: 0x001D5860 File Offset: 0x001D3A60
		public string GetIconArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetIconArrayName_25(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BC0 RID: 84928
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetIconSize_26(HandleRef pThis);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x06014BC1 RID: 84929 RVA: 0x001D589C File Offset: 0x001D3A9C
		public IntPtr GetIconSize()
		{
			return vtkGraphMapper.vtkGraphMapper_GetIconSize_26(base.GetCppThis());
		}

		// Token: 0x06014BC2 RID: 84930
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetIconTexture_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The texture containing the icon sheet.
		/// </summary>
		// Token: 0x06014BC3 RID: 84931 RVA: 0x001D58BC File Offset: 0x001D3ABC
		public vtkTexture GetIconTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetIconTexture_27(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		// Token: 0x06014BC4 RID: 84932
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphMapper_GetIconVisibility_28(HandleRef pThis);

		/// <summary>
		/// Whether to show icons.  Default is off.
		/// </summary>
		// Token: 0x06014BC5 RID: 84933 RVA: 0x001D592C File Offset: 0x001D3B2C
		public bool GetIconVisibility()
		{
			return vtkGraphMapper.vtkGraphMapper_GetIconVisibility_28(base.GetCppThis()) != 0;
		}

		// Token: 0x06014BC6 RID: 84934
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetInput_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the Input of this mapper.
		/// </summary>
		// Token: 0x06014BC7 RID: 84935 RVA: 0x001D5954 File Offset: 0x001D3B54
		public new vtkGraph GetInput()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetInput_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x06014BC8 RID: 84936
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkGraphMapper_GetMTime_30(HandleRef pThis);

		/// <summary>
		/// Get the mtime also considering the lookup table.
		/// </summary>
		// Token: 0x06014BC9 RID: 84937 RVA: 0x001D59C4 File Offset: 0x001D3BC4
		public override ulong GetMTime()
		{
			return vtkGraphMapper.vtkGraphMapper_GetMTime_30(base.GetCppThis());
		}

		// Token: 0x06014BCA RID: 84938
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphMapper_GetNumberOfGenerationsFromBase_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BCB RID: 84939 RVA: 0x001D59E4 File Offset: 0x001D3BE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_GetNumberOfGenerationsFromBase_31(base.GetCppThis(), type);
		}

		// Token: 0x06014BCC RID: 84940
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphMapper_GetNumberOfGenerationsFromBaseType_32([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BCD RID: 84941 RVA: 0x001D5A04 File Offset: 0x001D3C04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_GetNumberOfGenerationsFromBaseType_32(type);
		}

		// Token: 0x06014BCE RID: 84942
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkGraphMapper_GetScaledGlyphs_33(HandleRef pThis);

		/// <summary>
		/// Whether scaled glyphs are on or not.  Default is off.
		/// By default this mapper uses vertex glyphs that do not
		/// scale. If you turn this option on you will get circles
		/// at each vertex and they will scale as you zoom in/out.
		/// </summary>
		// Token: 0x06014BCF RID: 84943 RVA: 0x001D5A20 File Offset: 0x001D3C20
		public virtual bool GetScaledGlyphs()
		{
			return vtkGraphMapper.vtkGraphMapper_GetScaledGlyphs_33(base.GetCppThis()) != 0;
		}

		// Token: 0x06014BD0 RID: 84944
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetScalingArrayName_34(HandleRef pThis);

		/// <summary>
		/// Glyph scaling array name. Default is "scale"
		/// </summary>
		// Token: 0x06014BD1 RID: 84945 RVA: 0x001D5A48 File Offset: 0x001D3C48
		public virtual string GetScalingArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetScalingArrayName_34(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BD2 RID: 84946
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetVertexColorArrayName_35(HandleRef pThis);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x06014BD3 RID: 84947 RVA: 0x001D5A84 File Offset: 0x001D3C84
		public string GetVertexColorArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphMapper.vtkGraphMapper_GetVertexColorArrayName_35(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014BD4 RID: 84948
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_GetVertexLookupTable_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access to the lookup tables used by the vertex and edge mappers.
		/// </summary>
		// Token: 0x06014BD5 RID: 84949 RVA: 0x001D5AC0 File Offset: 0x001D3CC0
		public virtual vtkLookupTable GetVertexLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_GetVertexLookupTable_36(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		// Token: 0x06014BD6 RID: 84950
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkGraphMapper_GetVertexPointSize_37(HandleRef pThis);

		/// <summary>
		/// Get/Set the vertex point size
		/// </summary>
		// Token: 0x06014BD7 RID: 84951 RVA: 0x001D5B30 File Offset: 0x001D3D30
		public virtual float GetVertexPointSize()
		{
			return vtkGraphMapper.vtkGraphMapper_GetVertexPointSize_37(base.GetCppThis());
		}

		// Token: 0x06014BD8 RID: 84952
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_IconVisibilityOff_38(HandleRef pThis);

		/// <summary>
		/// Whether to show icons.  Default is off.
		/// </summary>
		// Token: 0x06014BD9 RID: 84953 RVA: 0x001D5B4F File Offset: 0x001D3D4F
		public virtual void IconVisibilityOff()
		{
			vtkGraphMapper.vtkGraphMapper_IconVisibilityOff_38(base.GetCppThis());
		}

		// Token: 0x06014BDA RID: 84954
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_IconVisibilityOn_39(HandleRef pThis);

		/// <summary>
		/// Whether to show icons.  Default is off.
		/// </summary>
		// Token: 0x06014BDB RID: 84955 RVA: 0x001D5B5E File Offset: 0x001D3D5E
		public virtual void IconVisibilityOn()
		{
			vtkGraphMapper.vtkGraphMapper_IconVisibilityOn_39(base.GetCppThis());
		}

		// Token: 0x06014BDC RID: 84956
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphMapper_IsA_40(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BDD RID: 84957 RVA: 0x001D5B70 File Offset: 0x001D3D70
		public override int IsA(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_IsA_40(base.GetCppThis(), type);
		}

		// Token: 0x06014BDE RID: 84958
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphMapper_IsTypeOf_41([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BDF RID: 84959 RVA: 0x001D5B90 File Offset: 0x001D3D90
		public new static int IsTypeOf(string type)
		{
			return vtkGraphMapper.vtkGraphMapper_IsTypeOf_41(type);
		}

		// Token: 0x06014BE0 RID: 84960
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_NewInstance_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BE1 RID: 84961 RVA: 0x001D5BAC File Offset: 0x001D3DAC
		public new vtkGraphMapper NewInstance()
		{
			vtkGraphMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_NewInstance_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014BE2 RID: 84962
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014BE3 RID: 84963 RVA: 0x001D5C08 File Offset: 0x001D3E08
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkGraphMapper.vtkGraphMapper_ReleaseGraphicsResources_44(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014BE4 RID: 84964
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_Render_45(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BE5 RID: 84965 RVA: 0x001D5C38 File Offset: 0x001D3E38
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkGraphMapper.vtkGraphMapper_Render_45(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x06014BE6 RID: 84966
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphMapper_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014BE7 RID: 84967 RVA: 0x001D5C7C File Offset: 0x001D3E7C
		public new static vtkGraphMapper SafeDownCast(vtkObjectBase o)
		{
			vtkGraphMapper vtkGraphMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphMapper.vtkGraphMapper_SafeDownCast_46((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphMapper = (vtkGraphMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphMapper.Register(null);
				}
			}
			return vtkGraphMapper;
		}

		// Token: 0x06014BE8 RID: 84968
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ScaledGlyphsOff_47(HandleRef pThis);

		/// <summary>
		/// Whether scaled glyphs are on or not.  Default is off.
		/// By default this mapper uses vertex glyphs that do not
		/// scale. If you turn this option on you will get circles
		/// at each vertex and they will scale as you zoom in/out.
		/// </summary>
		// Token: 0x06014BE9 RID: 84969 RVA: 0x001D5CFB File Offset: 0x001D3EFB
		public virtual void ScaledGlyphsOff()
		{
			vtkGraphMapper.vtkGraphMapper_ScaledGlyphsOff_47(base.GetCppThis());
		}

		// Token: 0x06014BEA RID: 84970
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_ScaledGlyphsOn_48(HandleRef pThis);

		/// <summary>
		/// Whether scaled glyphs are on or not.  Default is off.
		/// By default this mapper uses vertex glyphs that do not
		/// scale. If you turn this option on you will get circles
		/// at each vertex and they will scale as you zoom in/out.
		/// </summary>
		// Token: 0x06014BEB RID: 84971 RVA: 0x001D5D0A File Offset: 0x001D3F0A
		public virtual void ScaledGlyphsOn()
		{
			vtkGraphMapper.vtkGraphMapper_ScaledGlyphsOn_48(base.GetCppThis());
		}

		// Token: 0x06014BEC RID: 84972
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetColorEdges_49(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color edges.  Default is off.
		/// </summary>
		// Token: 0x06014BED RID: 84973 RVA: 0x001D5D19 File Offset: 0x001D3F19
		public void SetColorEdges(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetColorEdges_49(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06014BEE RID: 84974
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetColorVertices_50(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to color vertices.  Default is off.
		/// </summary>
		// Token: 0x06014BEF RID: 84975 RVA: 0x001D5D31 File Offset: 0x001D3F31
		public void SetColorVertices(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetColorVertices_50(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06014BF0 RID: 84976
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEdgeColorArrayName_51(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BF1 RID: 84977 RVA: 0x001D5D49 File Offset: 0x001D3F49
		public void SetEdgeColorArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeColorArrayName_51(base.GetCppThis(), name);
		}

		// Token: 0x06014BF2 RID: 84978
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEdgeLineWidth_52(HandleRef pThis, float width);

		/// <summary>
		/// Get/Set the edge line width
		/// </summary>
		// Token: 0x06014BF3 RID: 84979 RVA: 0x001D5D59 File Offset: 0x001D3F59
		public void SetEdgeLineWidth(float width)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeLineWidth_52(base.GetCppThis(), width);
		}

		// Token: 0x06014BF4 RID: 84980
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEdgeVisibility_53(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show edges or not.  Default is on.
		/// </summary>
		// Token: 0x06014BF5 RID: 84981 RVA: 0x001D5D69 File Offset: 0x001D3F69
		public void SetEdgeVisibility(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetEdgeVisibility_53(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06014BF6 RID: 84982
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEnableEdgesByArray_54(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether to enable/disable edges using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BF7 RID: 84983 RVA: 0x001D5D81 File Offset: 0x001D3F81
		public virtual void SetEnableEdgesByArray(int _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnableEdgesByArray_54(base.GetCppThis(), _arg);
		}

		// Token: 0x06014BF8 RID: 84984
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEnableVerticesByArray_55(HandleRef pThis, int _arg);

		/// <summary>
		/// Whether to enable/disable vertices using array values.  Default is off.
		/// </summary>
		// Token: 0x06014BF9 RID: 84985 RVA: 0x001D5D91 File Offset: 0x001D3F91
		public virtual void SetEnableVerticesByArray(int _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnableVerticesByArray_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06014BFA RID: 84986
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEnabledEdgesArrayName_56(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BFB RID: 84987 RVA: 0x001D5DA1 File Offset: 0x001D3FA1
		public virtual void SetEnabledEdgesArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnabledEdgesArrayName_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06014BFC RID: 84988
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetEnabledVerticesArrayName_57(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The array to use for coloring edges.  Default is "color".
		/// </summary>
		// Token: 0x06014BFD RID: 84989 RVA: 0x001D5DB1 File Offset: 0x001D3FB1
		public virtual void SetEnabledVerticesArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetEnabledVerticesArrayName_57(base.GetCppThis(), _arg);
		}

		// Token: 0x06014BFE RID: 84990
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetIconAlignment_58(HandleRef pThis, int alignment);

		/// <summary>
		/// Specify where the icons should be placed in relation to the vertex.
		/// See vtkIconGlyphFilter.h for possible values.
		/// </summary>
		// Token: 0x06014BFF RID: 84991 RVA: 0x001D5DC1 File Offset: 0x001D3FC1
		public void SetIconAlignment(int alignment)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconAlignment_58(base.GetCppThis(), alignment);
		}

		// Token: 0x06014C00 RID: 84992
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetIconArrayName_59(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for assigning icons.
		/// </summary>
		// Token: 0x06014C01 RID: 84993 RVA: 0x001D5DD1 File Offset: 0x001D3FD1
		public void SetIconArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconArrayName_59(base.GetCppThis(), name);
		}

		// Token: 0x06014C02 RID: 84994
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetIconSize_60(HandleRef pThis, IntPtr size);

		/// <summary>
		/// Specify the Width and Height, in pixels, of an icon in the icon sheet.
		/// </summary>
		// Token: 0x06014C03 RID: 84995 RVA: 0x001D5DE1 File Offset: 0x001D3FE1
		public void SetIconSize(IntPtr size)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconSize_60(base.GetCppThis(), size);
		}

		// Token: 0x06014C04 RID: 84996
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetIconTexture_61(HandleRef pThis, HandleRef texture);

		/// <summary>
		/// The texture containing the icon sheet.
		/// </summary>
		// Token: 0x06014C05 RID: 84997 RVA: 0x001D5DF4 File Offset: 0x001D3FF4
		public void SetIconTexture(vtkTexture texture)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconTexture_61(base.GetCppThis(), (texture == null) ? default(HandleRef) : texture.GetCppThis());
		}

		// Token: 0x06014C06 RID: 84998
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetIconVisibility_62(HandleRef pThis, byte vis);

		/// <summary>
		/// Whether to show icons.  Default is off.
		/// </summary>
		// Token: 0x06014C07 RID: 84999 RVA: 0x001D5E23 File Offset: 0x001D4023
		public void SetIconVisibility(bool vis)
		{
			vtkGraphMapper.vtkGraphMapper_SetIconVisibility_62(base.GetCppThis(), vis ? (byte)1 : (byte)0);
		}

		// Token: 0x06014C08 RID: 85000
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetInputData_63(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the Input of this mapper.
		/// </summary>
		// Token: 0x06014C09 RID: 85001 RVA: 0x001D5E3C File Offset: 0x001D403C
		public void SetInputData(vtkGraph input)
		{
			vtkGraphMapper.vtkGraphMapper_SetInputData_63(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06014C0A RID: 85002
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetScaledGlyphs_64(HandleRef pThis, byte arg);

		/// <summary>
		/// Whether scaled glyphs are on or not.  Default is off.
		/// By default this mapper uses vertex glyphs that do not
		/// scale. If you turn this option on you will get circles
		/// at each vertex and they will scale as you zoom in/out.
		/// </summary>
		// Token: 0x06014C0B RID: 85003 RVA: 0x001D5E6B File Offset: 0x001D406B
		public void SetScaledGlyphs(bool arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetScaledGlyphs_64(base.GetCppThis(), arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06014C0C RID: 85004
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetScalingArrayName_65(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Glyph scaling array name. Default is "scale"
		/// </summary>
		// Token: 0x06014C0D RID: 85005 RVA: 0x001D5E83 File Offset: 0x001D4083
		public virtual void SetScalingArrayName(string _arg)
		{
			vtkGraphMapper.vtkGraphMapper_SetScalingArrayName_65(base.GetCppThis(), _arg);
		}

		// Token: 0x06014C0E RID: 85006
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetVertexColorArrayName_66(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// The array to use for coloring vertices.  Default is "color".
		/// </summary>
		// Token: 0x06014C0F RID: 85007 RVA: 0x001D5E93 File Offset: 0x001D4093
		public void SetVertexColorArrayName(string name)
		{
			vtkGraphMapper.vtkGraphMapper_SetVertexColorArrayName_66(base.GetCppThis(), name);
		}

		// Token: 0x06014C10 RID: 85008
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphMapper_SetVertexPointSize_67(HandleRef pThis, float size);

		/// <summary>
		/// Get/Set the vertex point size
		/// </summary>
		// Token: 0x06014C11 RID: 85009 RVA: 0x001D5EA3 File Offset: 0x001D40A3
		public void SetVertexPointSize(float size)
		{
			vtkGraphMapper.vtkGraphMapper_SetVertexPointSize_67(base.GetCppThis(), size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017F1 RID: 6129
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017F2 RID: 6130
		public new static readonly string MRClassNameKey = "class vtkGraphMapper";
	}
}
