using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPropAssembly
	/// </summary>
	/// <remarks>
	///    create hierarchies of props
	///
	/// vtkPropAssembly is an object that groups props and other prop assemblies
	/// into a tree-like hierarchy. The props can then be treated as a group
	/// (e.g., turning visibility on and off).
	///
	/// A vtkPropAssembly object can be used in place of an vtkProp since it is a
	/// subclass of vtkProp. The difference is that vtkPropAssembly maintains a
	/// list of other prop and prop assembly instances (its "parts") that form the
	/// assembly. Note that this process is recursive: you can create groups
	/// consisting of prop assemblies to arbitrary depth.
	///
	/// vtkPropAssembly's and vtkProp's that compose a prop assembly need not be
	/// added to a renderer's list of props, as long as the parent assembly is in
	/// the prop list. This is because they are automatically rendered during
	/// the hierarchical traversal process.
	///
	/// @warning
	/// vtkPropAssemblies can consist of hierarchies of assemblies, where one
	/// actor or assembly used in one hierarchy is also used in other
	/// hierarchies. However, make that there are no cycles (e.g.,
	/// parent-&gt;child-&gt;parent), this will cause program failure.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkProp3D vtkActor vtkAssembly vtkActor2D vtkVolume
	/// </seealso>
	// Token: 0x020007F8 RID: 2040
	public class vtkPropAssembly : vtkProp
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014F38 RID: 85816 RVA: 0x001DA4D3 File Offset: 0x001D86D3
		static vtkPropAssembly()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPropAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPropAssembly"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014F39 RID: 85817 RVA: 0x001DA4FB File Offset: 0x001D86FB
		public vtkPropAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014F3A RID: 85818
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create with an empty parts list.
		/// </summary>
		// Token: 0x06014F3B RID: 85819 RVA: 0x001DA50C File Offset: 0x001D870C
		public new static vtkPropAssembly New()
		{
			vtkPropAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create with an empty parts list.
		/// </summary>
		// Token: 0x06014F3C RID: 85820 RVA: 0x001DA560 File Offset: 0x001D8760
		public vtkPropAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPropAssembly.vtkPropAssembly_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014F3D RID: 85821 RVA: 0x001DA5A4 File Offset: 0x001D87A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014F3E RID: 85822
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a part to the list of parts.
		/// </summary>
		// Token: 0x06014F3F RID: 85823 RVA: 0x001DA5B0 File Offset: 0x001D87B0
		public void AddPart(vtkProp arg0)
		{
			vtkPropAssembly.vtkPropAssembly_AddPart_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014F40 RID: 85824
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
		/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
		/// Overload the superclass' vtkProp BuildPaths() method.
		/// </summary>
		// Token: 0x06014F41 RID: 85825 RVA: 0x001DA5E0 File Offset: 0x001D87E0
		public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkPropAssembly.vtkPropAssembly_BuildPaths_02(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		// Token: 0x06014F42 RID: 85826
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_GetBounds_03(HandleRef pThis);

		/// <summary>
		/// Get the bounds for this prop assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// May return NULL in some cases (meaning the bounds is undefined).
		/// </summary>
		// Token: 0x06014F43 RID: 85827 RVA: 0x001DA624 File Offset: 0x001D8824
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetBounds_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06014F44 RID: 85828
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkPropAssembly_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Override default GetMTime method to also consider all of the
		/// prop assembly's parts.
		/// </summary>
		// Token: 0x06014F45 RID: 85829 RVA: 0x001DA66C File Offset: 0x001D886C
		public override ulong GetMTime()
		{
			return vtkPropAssembly.vtkPropAssembly_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06014F46 RID: 85830
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_GetNextPath_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods to traverse the paths (i.e., leaf nodes) of a prop
		/// assembly. These methods should be contrasted to those that traverse the
		/// list of parts using GetParts().  GetParts() returns a list of children
		/// of this assembly, not necessarily the leaf nodes of the assembly. To use
		/// the methods below - first invoke InitPathTraversal() followed by
		/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
		/// when the list is exhausted. (See the superclass vtkProp for more
		/// information about paths.)
		/// </summary>
		// Token: 0x06014F47 RID: 85831 RVA: 0x001DA68C File Offset: 0x001D888C
		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetNextPath_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssemblyPath = (vtkAssemblyPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssemblyPath.Register(null);
				}
			}
			return vtkAssemblyPath;
		}

		// Token: 0x06014F48 RID: 85832
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropAssembly_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F49 RID: 85833 RVA: 0x001DA6FC File Offset: 0x001D88FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06014F4A RID: 85834
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPropAssembly_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F4B RID: 85835 RVA: 0x001DA71C File Offset: 0x001D891C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06014F4C RID: 85836
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_GetNumberOfPaths_08(HandleRef pThis);

		/// <summary>
		/// Methods to traverse the paths (i.e., leaf nodes) of a prop
		/// assembly. These methods should be contrasted to those that traverse the
		/// list of parts using GetParts().  GetParts() returns a list of children
		/// of this assembly, not necessarily the leaf nodes of the assembly. To use
		/// the methods below - first invoke InitPathTraversal() followed by
		/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
		/// when the list is exhausted. (See the superclass vtkProp for more
		/// information about paths.)
		/// </summary>
		// Token: 0x06014F4D RID: 85837 RVA: 0x001DA738 File Offset: 0x001D8938
		public override int GetNumberOfPaths()
		{
			return vtkPropAssembly.vtkPropAssembly_GetNumberOfPaths_08(base.GetCppThis());
		}

		// Token: 0x06014F4E RID: 85838
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_GetParts_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the list of parts.
		/// </summary>
		// Token: 0x06014F4F RID: 85839 RVA: 0x001DA758 File Offset: 0x001D8958
		public vtkPropCollection GetParts()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_GetParts_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		// Token: 0x06014F50 RID: 85840
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_HasTranslucentPolygonalGeometry_10(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x06014F51 RID: 85841 RVA: 0x001DA7C8 File Offset: 0x001D89C8
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkPropAssembly.vtkPropAssembly_HasTranslucentPolygonalGeometry_10(base.GetCppThis());
		}

		// Token: 0x06014F52 RID: 85842
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_InitPathTraversal_11(HandleRef pThis);

		/// <summary>
		/// Methods to traverse the paths (i.e., leaf nodes) of a prop
		/// assembly. These methods should be contrasted to those that traverse the
		/// list of parts using GetParts().  GetParts() returns a list of children
		/// of this assembly, not necessarily the leaf nodes of the assembly. To use
		/// the methods below - first invoke InitPathTraversal() followed by
		/// repeated calls to GetNextPath().  GetNextPath() returns a NULL pointer
		/// when the list is exhausted. (See the superclass vtkProp for more
		/// information about paths.)
		/// </summary>
		// Token: 0x06014F53 RID: 85843 RVA: 0x001DA7E7 File Offset: 0x001D89E7
		public override void InitPathTraversal()
		{
			vtkPropAssembly.vtkPropAssembly_InitPathTraversal_11(base.GetCppThis());
		}

		// Token: 0x06014F54 RID: 85844
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F55 RID: 85845 RVA: 0x001DA7F8 File Offset: 0x001D89F8
		public override int IsA(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06014F56 RID: 85846
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F57 RID: 85847 RVA: 0x001DA818 File Offset: 0x001D8A18
		public new static int IsTypeOf(string type)
		{
			return vtkPropAssembly.vtkPropAssembly_IsTypeOf_13(type);
		}

		// Token: 0x06014F58 RID: 85848
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F59 RID: 85849 RVA: 0x001DA834 File Offset: 0x001D8A34
		public new vtkPropAssembly NewInstance()
		{
			vtkPropAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014F5A RID: 85850
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014F5B RID: 85851 RVA: 0x001DA890 File Offset: 0x001D8A90
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkPropAssembly.vtkPropAssembly_ReleaseGraphicsResources_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014F5C RID: 85852
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_RemovePart_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a part from the list of parts,
		/// </summary>
		// Token: 0x06014F5D RID: 85853 RVA: 0x001DA8C0 File Offset: 0x001D8AC0
		public void RemovePart(vtkProp arg0)
		{
			vtkPropAssembly.vtkPropAssembly_RemovePart_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014F5E RID: 85854
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_RenderOpaqueGeometry_18(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.  The rendering process is
		/// recursive. The parts of each assembly are rendered only if the
		/// visibility for the prop is turned on.
		/// </summary>
		// Token: 0x06014F5F RID: 85855 RVA: 0x001DA8F0 File Offset: 0x001D8AF0
		public override int RenderOpaqueGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderOpaqueGeometry_18(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014F60 RID: 85856
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_RenderOverlay_19(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.  The rendering process is
		/// recursive. The parts of each assembly are rendered only if the
		/// visibility for the prop is turned on.
		/// </summary>
		// Token: 0x06014F61 RID: 85857 RVA: 0x001DA924 File Offset: 0x001D8B24
		public override int RenderOverlay(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderOverlay_19(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014F62 RID: 85858
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_RenderTranslucentPolygonalGeometry_20(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.  The rendering process is
		/// recursive. The parts of each assembly are rendered only if the
		/// visibility for the prop is turned on.
		/// </summary>
		// Token: 0x06014F63 RID: 85859 RVA: 0x001DA958 File Offset: 0x001D8B58
		public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderTranslucentPolygonalGeometry_20(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014F64 RID: 85860
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPropAssembly_RenderVolumetricGeometry_21(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.  The rendering process is
		/// recursive. The parts of each assembly are rendered only if the
		/// visibility for the prop is turned on.
		/// </summary>
		// Token: 0x06014F65 RID: 85861 RVA: 0x001DA98C File Offset: 0x001D8B8C
		public override int RenderVolumetricGeometry(vtkViewport ren)
		{
			return vtkPropAssembly.vtkPropAssembly_RenderVolumetricGeometry_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014F66 RID: 85862
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPropAssembly_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014F67 RID: 85863 RVA: 0x001DA9C0 File Offset: 0x001D8BC0
		public new static vtkPropAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkPropAssembly vtkPropAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPropAssembly.vtkPropAssembly_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropAssembly = (vtkPropAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropAssembly.Register(null);
				}
			}
			return vtkPropAssembly;
		}

		// Token: 0x06014F68 RID: 85864
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPropAssembly_ShallowCopy_23(HandleRef pThis, HandleRef Prop);

		/// <summary>
		/// Shallow copy of this vtkPropAssembly.
		/// </summary>
		// Token: 0x06014F69 RID: 85865 RVA: 0x001DAA40 File Offset: 0x001D8C40
		public override void ShallowCopy(vtkProp Prop)
		{
			vtkPropAssembly.vtkPropAssembly_ShallowCopy_23(base.GetCppThis(), (Prop == null) ? default(HandleRef) : Prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001834 RID: 6196
		public new const string MRFullTypeName = "Kitware.VTK.vtkPropAssembly";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001835 RID: 6197
		public new static readonly string MRClassNameKey = "class vtkPropAssembly";
	}
}
