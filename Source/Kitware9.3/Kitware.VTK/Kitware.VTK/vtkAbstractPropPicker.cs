using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractPropPicker
	/// </summary>
	/// <remarks>
	///    abstract API for pickers that can pick an instance of vtkProp
	///
	/// vtkAbstractPropPicker is an abstract superclass for pickers that can pick
	/// an instance of vtkProp. Some pickers, like vtkWorldPointPicker (not a
	/// subclass of this class), cannot identify the prop that is
	/// picked. Subclasses of vtkAbstractPropPicker return a prop in the form of a
	/// vtkAssemblyPath when a pick is invoked. Note that an vtkAssemblyPath
	/// contain a list of vtkAssemblyNodes, each of which in turn contains a
	/// reference to a vtkProp and a 4x4 transformation matrix. The path fully
	/// describes the entire pick path, so you can pick assemblies or portions of
	/// assemblies, or just grab the tail end of the vtkAssemblyPath (which is the
	/// picked prop).
	///
	/// @warning
	/// Because a vtkProp can be placed into different assemblies, or even in
	/// different leaf positions of the same assembly, the vtkAssemblyPath is
	/// used to fully qualify exactly which use of the vtkProp was picked,
	/// including its position (since vtkAssemblyPath includes a transformation
	/// matrix per node).
	///
	/// @warning
	/// The class returns information about picked actors, props, etc. Note that
	/// what is returned by these methods is the top level of the assembly
	/// path. This can cause a lot of confusion! For example, if you pick a
	/// vtkAssembly, and the returned vtkAssemblyPath has as a leaf a vtkActor,
	/// then if you invoke GetActor(), you will get NULL, even though an actor was
	/// indeed picked. (GetAssembly() will return something.) Note that the safest
	/// thing to do is to do a GetViewProp(), which will always return something if
	/// something was picked. A better way to manage picking is to work with
	/// vtkAssemblyPath, since this completely defines the pick path from top to
	/// bottom in a assembly hierarchy, and avoids confusion when the same prop is
	/// used in different assemblies.
	///
	/// @warning
	/// The returned assembly paths refer to assembly nodes that in turn refer
	/// to vtkProp and vtkMatrix. This association to vtkProp is not a reference
	/// counted association, meaning that dangling references are possible if
	/// you do a pick, get an assembly path, and then delete a vtkProp. (Reason:
	/// assembly paths create many self-referencing loops that destroy reference
	/// counting.)
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPropPicker vtkPicker vtkWorldPointPicker vtkCellPicker vtkPointPicker
	/// vtkAssemblyPath vtkAssemblyNode vtkAssemblyPaths vtkAbstractPicker
	/// vtkRenderer
	/// </seealso>
	// Token: 0x020000BD RID: 189
	public abstract class vtkAbstractPropPicker : vtkAbstractPicker
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06002987 RID: 10631 RVA: 0x0003D303 File Offset: 0x0003B503
		static vtkAbstractPropPicker()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPropPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPropPicker"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06002988 RID: 10632 RVA: 0x0003D32B File Offset: 0x0003B52B
		public vtkAbstractPropPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06002989 RID: 10633 RVA: 0x0003D339 File Offset: 0x0003B539
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600298A RID: 10634
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetActor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkActor that has been picked. If NULL, no actor was picked.
		/// </summary>
		// Token: 0x0600298B RID: 10635 RVA: 0x0003D344 File Offset: 0x0003B544
		public virtual vtkActor GetActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetActor_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x0600298C RID: 10636
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetActor2D_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkActor2D that has been picked. If NULL, no actor2D was
		/// picked.
		/// </summary>
		// Token: 0x0600298D RID: 10637 RVA: 0x0003D3B4 File Offset: 0x0003B5B4
		public virtual vtkActor2D GetActor2D()
		{
			vtkActor2D vtkActor2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetActor2D_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor2D = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor2D.Register(null);
				}
			}
			return vtkActor2D;
		}

		// Token: 0x0600298E RID: 10638
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetAssembly_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkAssembly that has been picked. If NULL, no assembly
		/// was picked. (Note: the returned assembly is the first node in the
		/// assembly path. If the path is one node long, then the assembly and
		/// the prop are the same, assuming that the first node is a vtkAssembly.)
		/// </summary>
		// Token: 0x0600298F RID: 10639 RVA: 0x0003D424 File Offset: 0x0003B624
		public virtual vtkAssembly GetAssembly()
		{
			vtkAssembly vtkAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetAssembly_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAssembly = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAssembly.Register(null);
				}
			}
			return vtkAssembly;
		}

		// Token: 0x06002990 RID: 10640
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPropPicker_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002991 RID: 10641 RVA: 0x0003D494 File Offset: 0x0003B694
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractPropPicker.vtkAbstractPropPicker_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06002992 RID: 10642
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractPropPicker_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06002993 RID: 10643 RVA: 0x0003D4B4 File Offset: 0x0003B6B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractPropPicker.vtkAbstractPropPicker_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06002994 RID: 10644
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetPath_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkAssemblyPath that has been picked. The assembly path lists
		/// all the vtkProps that form an assembly. If no assembly is present, then
		/// the assembly path will have one node (which is the picked prop). The
		/// set method is used internally to set the path. (Note: the structure of
		/// an assembly path is a collection of vtkAssemblyNode, each node pointing
		/// to a vtkProp and (possibly) a transformation matrix.)
		/// </summary>
		// Token: 0x06002995 RID: 10645 RVA: 0x0003D4D0 File Offset: 0x0003B6D0
		public virtual vtkAssemblyPath GetPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetPath_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06002996 RID: 10646
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetProp3D_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkProp that has been picked. If NULL, no vtkProp3D was picked.
		/// </summary>
		// Token: 0x06002997 RID: 10647 RVA: 0x0003D540 File Offset: 0x0003B740
		public virtual vtkProp3D GetProp3D()
		{
			vtkProp3D vtkProp3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetProp3D_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3D = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3D.Register(null);
				}
			}
			return vtkProp3D;
		}

		// Token: 0x06002998 RID: 10648
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetPropAssembly_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkPropAssembly that has been picked. If NULL, no prop
		/// assembly was picked. (Note: the returned prop assembly is the first node
		/// in the assembly path. If the path is one node long, then the prop
		/// assembly and the prop are the same, assuming that the first node is a
		/// vtkPropAssembly.)
		/// </summary>
		// Token: 0x06002999 RID: 10649 RVA: 0x0003D5B0 File Offset: 0x0003B7B0
		public virtual vtkPropAssembly GetPropAssembly()
		{
			vtkPropAssembly vtkPropAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetPropAssembly_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600299A RID: 10650
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetViewProp_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkProp that has been picked. If NULL, nothing was picked.
		/// If anything at all was picked, this method will return something.
		/// </summary>
		// Token: 0x0600299B RID: 10651 RVA: 0x0003D620 File Offset: 0x0003B820
		public virtual vtkProp GetViewProp()
		{
			vtkProp vtkProp = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetViewProp_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp = (vtkProp)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp.Register(null);
				}
			}
			return vtkProp;
		}

		// Token: 0x0600299C RID: 10652
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_GetVolume_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the vtkVolume that has been picked. If NULL, no volume was picked.
		/// </summary>
		// Token: 0x0600299D RID: 10653 RVA: 0x0003D690 File Offset: 0x0003B890
		public virtual vtkVolume GetVolume()
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_GetVolume_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x0600299E RID: 10654
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPropPicker_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600299F RID: 10655 RVA: 0x0003D700 File Offset: 0x0003B900
		public override int IsA(string type)
		{
			return vtkAbstractPropPicker.vtkAbstractPropPicker_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060029A0 RID: 10656
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractPropPicker_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029A1 RID: 10657 RVA: 0x0003D720 File Offset: 0x0003B920
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPropPicker.vtkAbstractPropPicker_IsTypeOf_12(type);
		}

		// Token: 0x060029A2 RID: 10658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029A3 RID: 10659 RVA: 0x0003D73C File Offset: 0x0003B93C
		public new vtkAbstractPropPicker NewInstance()
		{
			vtkAbstractPropPicker result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060029A4 RID: 10660
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractPropPicker_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060029A5 RID: 10661 RVA: 0x0003D798 File Offset: 0x0003B998
		public new static vtkAbstractPropPicker SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPropPicker vtkAbstractPropPicker = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractPropPicker.vtkAbstractPropPicker_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPropPicker = (vtkAbstractPropPicker)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPropPicker.Register(null);
				}
			}
			return vtkAbstractPropPicker;
		}

		// Token: 0x060029A6 RID: 10662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractPropPicker_SetPath_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Return the vtkAssemblyPath that has been picked. The assembly path lists
		/// all the vtkProps that form an assembly. If no assembly is present, then
		/// the assembly path will have one node (which is the picked prop). The
		/// set method is used internally to set the path. (Note: the structure of
		/// an assembly path is a collection of vtkAssemblyNode, each node pointing
		/// to a vtkProp and (possibly) a transformation matrix.)
		/// </summary>
		// Token: 0x060029A7 RID: 10663 RVA: 0x0003D818 File Offset: 0x0003BA18
		public virtual void SetPath(vtkAssemblyPath arg0)
		{
			vtkAbstractPropPicker.vtkAbstractPropPicker_SetPath_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000566 RID: 1382
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPropPicker";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000567 RID: 1383
		public new static readonly string MRClassNameKey = "class vtkAbstractPropPicker";
	}
}
