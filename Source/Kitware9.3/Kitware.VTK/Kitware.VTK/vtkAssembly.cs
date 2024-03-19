using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAssembly
	/// </summary>
	/// <remarks>
	///    create hierarchies of vtkProp3Ds (transformable props)
	///
	/// vtkAssembly is an object that groups vtkProp3Ds, its subclasses, and
	/// other assemblies into a tree-like hierarchy. The vtkProp3Ds and
	/// assemblies can then be transformed together by transforming just the root
	/// assembly of the hierarchy.
	///
	/// A vtkAssembly object can be used in place of an vtkProp3D since it is a
	/// subclass of vtkProp3D. The difference is that vtkAssembly maintains a list
	/// of vtkProp3D instances (its "parts") that form the assembly. Then, any
	/// operation that transforms (i.e., scales, rotates, translates) the parent
	/// assembly will transform all its parts.  Note that this process is
	/// recursive: you can create groups consisting of assemblies and/or
	/// vtkProp3Ds to arbitrary depth.
	///
	/// To add an assembly to the renderer's list of props, you only need to
	/// add the root of the assembly. During rendering, the parts of the
	/// assembly are rendered during a hierarchical traversal process.
	///
	/// @warning
	/// Collections of assemblies are slower to render than an equivalent list
	/// of actors. This is because to support arbitrary nesting of assemblies,
	/// the state of the assemblies (i.e., transformation matrices) must
	/// be propagated through the assembly hierarchy.
	///
	/// @warning
	/// Assemblies can consist of hierarchies of assemblies, where one actor or
	/// assembly used in one hierarchy is also used in other hierarchies. However,
	/// make that there are no cycles (e.g., parent-&gt;child-&gt;parent), this will
	/// cause program failure.
	///
	/// @warning
	/// If you wish to create assemblies without any transformation (using the
	/// assembly strictly as a grouping mechanism), then you may wish to
	/// consider using vtkPropAssembly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkActor vtkTransform vtkMapper vtkPolyDataMapper vtkPropAssembly
	/// </seealso>
	// Token: 0x020007C8 RID: 1992
	public class vtkAssembly : vtkProp3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601461E RID: 83486 RVA: 0x001CD81F File Offset: 0x001CBA1F
		static vtkAssembly()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAssembly.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAssembly"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601461F RID: 83487 RVA: 0x001CD847 File Offset: 0x001CBA47
		public vtkAssembly(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014620 RID: 83488
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014621 RID: 83489 RVA: 0x001CD858 File Offset: 0x001CBA58
		public new static vtkAssembly New()
		{
			vtkAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssembly.vtkAssembly_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014622 RID: 83490 RVA: 0x001CD8AC File Offset: 0x001CBAAC
		public vtkAssembly() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAssembly.vtkAssembly_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014623 RID: 83491 RVA: 0x001CD8F0 File Offset: 0x001CBAF0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014624 RID: 83492
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_AddPart_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a part to the list of parts.
		/// </summary>
		// Token: 0x06014625 RID: 83493 RVA: 0x001CD8FC File Offset: 0x001CBAFC
		public void AddPart(vtkProp3D arg0)
		{
			vtkAssembly.vtkAssembly_AddPart_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014626 RID: 83494
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_BuildPaths_02(HandleRef pThis, HandleRef paths, HandleRef path);

		/// <summary>
		/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE DO NOT USE THIS
		/// METHOD OUTSIDE OF THE RENDERING PROCESS Overload the superclass' vtkProp
		/// BuildPaths() method. Paths consist of an ordered sequence of actors,
		/// with transformations properly concatenated.
		/// </summary>
		// Token: 0x06014627 RID: 83495 RVA: 0x001CD92C File Offset: 0x001CBB2C
		public override void BuildPaths(vtkAssemblyPaths paths, vtkAssemblyPath path)
		{
			vtkAssembly.vtkAssembly_BuildPaths_02(base.GetCppThis(), (paths == null) ? default(HandleRef) : paths.GetCppThis(), (path == null) ? default(HandleRef) : path.GetCppThis());
		}

		// Token: 0x06014628 RID: 83496
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_GetActors_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x06014629 RID: 83497 RVA: 0x001CD970 File Offset: 0x001CBB70
		public override void GetActors(vtkPropCollection arg0)
		{
			vtkAssembly.vtkAssembly_GetActors_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601462A RID: 83498
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_GetBounds_04(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// Get the bounds for the assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x0601462B RID: 83499 RVA: 0x001CD99F File Offset: 0x001CBB9F
		public new void GetBounds(IntPtr bounds)
		{
			vtkAssembly.vtkAssembly_GetBounds_04(base.GetCppThis(), bounds);
		}

		// Token: 0x0601462C RID: 83500
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// Get the bounds for the assembly as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
		/// </summary>
		// Token: 0x0601462D RID: 83501 RVA: 0x001CD9B0 File Offset: 0x001CBBB0
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601462E RID: 83502
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkAssembly_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// Override default GetMTime method to also consider all of the
		/// assembly's parts.
		/// </summary>
		// Token: 0x0601462F RID: 83503 RVA: 0x001CD9F8 File Offset: 0x001CBBF8
		public override ulong GetMTime()
		{
			return vtkAssembly.vtkAssembly_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06014630 RID: 83504
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_GetNextPath_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Methods to traverse the parts of an assembly. Each part (starting from
		/// the root) will appear properly transformed and with the correct
		/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
		/// Note that the part appears as an instance of vtkProp. These methods
		/// should be contrasted to those that traverse the list of parts using
		/// GetParts().  GetParts() returns a list of children of this assembly, not
		/// necessarily with the correct transformation or properties. To use the
		/// methods below - first invoke InitPathTraversal() followed by repeated
		/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
		/// list is exhausted.
		/// </summary>
		// Token: 0x06014631 RID: 83505 RVA: 0x001CDA18 File Offset: 0x001CBC18
		public override vtkAssemblyPath GetNextPath()
		{
			vtkAssemblyPath vtkAssemblyPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetNextPath_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014632 RID: 83506
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssembly_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014633 RID: 83507 RVA: 0x001CDA88 File Offset: 0x001CBC88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAssembly.vtkAssembly_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06014634 RID: 83508
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAssembly_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014635 RID: 83509 RVA: 0x001CDAA8 File Offset: 0x001CBCA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAssembly.vtkAssembly_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06014636 RID: 83510
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_GetNumberOfPaths_10(HandleRef pThis);

		/// <summary>
		/// Methods to traverse the parts of an assembly. Each part (starting from
		/// the root) will appear properly transformed and with the correct
		/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
		/// Note that the part appears as an instance of vtkProp. These methods
		/// should be contrasted to those that traverse the list of parts using
		/// GetParts().  GetParts() returns a list of children of this assembly, not
		/// necessarily with the correct transformation or properties. To use the
		/// methods below - first invoke InitPathTraversal() followed by repeated
		/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
		/// list is exhausted.
		/// </summary>
		// Token: 0x06014637 RID: 83511 RVA: 0x001CDAC4 File Offset: 0x001CBCC4
		public override int GetNumberOfPaths()
		{
			return vtkAssembly.vtkAssembly_GetNumberOfPaths_10(base.GetCppThis());
		}

		// Token: 0x06014638 RID: 83512
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_GetParts_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return the parts (direct descendants) of this assembly.
		/// </summary>
		// Token: 0x06014639 RID: 83513 RVA: 0x001CDAE4 File Offset: 0x001CBCE4
		public vtkProp3DCollection GetParts()
		{
			vtkProp3DCollection vtkProp3DCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssembly.vtkAssembly_GetParts_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProp3DCollection = (vtkProp3DCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProp3DCollection.Register(null);
				}
			}
			return vtkProp3DCollection;
		}

		// Token: 0x0601463A RID: 83514
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_GetVolumes_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// For some exporters and other other operations we must be
		/// able to collect all the actors or volumes. These methods
		/// are used in that process.
		/// </summary>
		// Token: 0x0601463B RID: 83515 RVA: 0x001CDB54 File Offset: 0x001CBD54
		public override void GetVolumes(vtkPropCollection arg0)
		{
			vtkAssembly.vtkAssembly_GetVolumes_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601463C RID: 83516
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_HasTranslucentPolygonalGeometry_13(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0601463D RID: 83517 RVA: 0x001CDB84 File Offset: 0x001CBD84
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkAssembly.vtkAssembly_HasTranslucentPolygonalGeometry_13(base.GetCppThis());
		}

		// Token: 0x0601463E RID: 83518
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_InitPathTraversal_14(HandleRef pThis);

		/// <summary>
		/// Methods to traverse the parts of an assembly. Each part (starting from
		/// the root) will appear properly transformed and with the correct
		/// properties (depending upon the ApplyProperty and ApplyTransform ivars).
		/// Note that the part appears as an instance of vtkProp. These methods
		/// should be contrasted to those that traverse the list of parts using
		/// GetParts().  GetParts() returns a list of children of this assembly, not
		/// necessarily with the correct transformation or properties. To use the
		/// methods below - first invoke InitPathTraversal() followed by repeated
		/// calls to GetNextPath().  GetNextPath() returns a NULL pointer when the
		/// list is exhausted.
		/// </summary>
		// Token: 0x0601463F RID: 83519 RVA: 0x001CDBA3 File Offset: 0x001CBDA3
		public override void InitPathTraversal()
		{
			vtkAssembly.vtkAssembly_InitPathTraversal_14(base.GetCppThis());
		}

		// Token: 0x06014640 RID: 83520
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014641 RID: 83521 RVA: 0x001CDBB4 File Offset: 0x001CBDB4
		public override int IsA(string type)
		{
			return vtkAssembly.vtkAssembly_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06014642 RID: 83522
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014643 RID: 83523 RVA: 0x001CDBD4 File Offset: 0x001CBDD4
		public new static int IsTypeOf(string type)
		{
			return vtkAssembly.vtkAssembly_IsTypeOf_16(type);
		}

		// Token: 0x06014644 RID: 83524
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014645 RID: 83525 RVA: 0x001CDBF0 File Offset: 0x001CBDF0
		public new vtkAssembly NewInstance()
		{
			vtkAssembly result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssembly.vtkAssembly_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAssembly)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014646 RID: 83526
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x06014647 RID: 83527 RVA: 0x001CDC4C File Offset: 0x001CBE4C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkAssembly.vtkAssembly_ReleaseGraphicsResources_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014648 RID: 83528
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_RemovePart_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove a part from the list of parts,
		/// </summary>
		// Token: 0x06014649 RID: 83529 RVA: 0x001CDC7C File Offset: 0x001CBE7C
		public void RemovePart(vtkProp3D arg0)
		{
			vtkAssembly.vtkAssembly_RemovePart_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601464A RID: 83530
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_RenderOpaqueGeometry_21(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.
		/// The rendering process is recursive.
		/// Note that a mapper need not be defined. If not defined, then no geometry
		/// will be drawn for this assembly. This allows you to create "logical"
		/// assemblies; that is, assemblies that only serve to group and transform
		/// its parts.
		/// </summary>
		// Token: 0x0601464B RID: 83531 RVA: 0x001CDCAC File Offset: 0x001CBEAC
		public override int RenderOpaqueGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderOpaqueGeometry_21(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0601464C RID: 83532
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.
		/// The rendering process is recursive.
		/// Note that a mapper need not be defined. If not defined, then no geometry
		/// will be drawn for this assembly. This allows you to create "logical"
		/// assemblies; that is, assemblies that only serve to group and transform
		/// its parts.
		/// </summary>
		// Token: 0x0601464D RID: 83533 RVA: 0x001CDCE0 File Offset: 0x001CBEE0
		public override int RenderTranslucentPolygonalGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x0601464E RID: 83534
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAssembly_RenderVolumetricGeometry_23(HandleRef pThis, HandleRef ren);

		/// <summary>
		/// Render this assembly and all its parts.
		/// The rendering process is recursive.
		/// Note that a mapper need not be defined. If not defined, then no geometry
		/// will be drawn for this assembly. This allows you to create "logical"
		/// assemblies; that is, assemblies that only serve to group and transform
		/// its parts.
		/// </summary>
		// Token: 0x0601464F RID: 83535 RVA: 0x001CDD14 File Offset: 0x001CBF14
		public override int RenderVolumetricGeometry(vtkViewport ren)
		{
			return vtkAssembly.vtkAssembly_RenderVolumetricGeometry_23(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		// Token: 0x06014650 RID: 83536
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAssembly_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014651 RID: 83537 RVA: 0x001CDD48 File Offset: 0x001CBF48
		public new static vtkAssembly SafeDownCast(vtkObjectBase o)
		{
			vtkAssembly vtkAssembly = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAssembly.vtkAssembly_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06014652 RID: 83538
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAssembly_ShallowCopy_25(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Shallow copy of an assembly. Overloads the virtual vtkProp method.
		/// </summary>
		// Token: 0x06014653 RID: 83539 RVA: 0x001CDDC8 File Offset: 0x001CBFC8
		public override void ShallowCopy(vtkProp prop)
		{
			vtkAssembly.vtkAssembly_ShallowCopy_25(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AE RID: 6062
		public new const string MRFullTypeName = "Kitware.VTK.vtkAssembly";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017AF RID: 6063
		public new static readonly string MRClassNameKey = "class vtkAssembly";
	}
}
