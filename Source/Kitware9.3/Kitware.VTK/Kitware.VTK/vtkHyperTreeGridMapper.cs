using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperTreeGridMapper
	/// </summary>
	/// <remarks>
	///    map vtkHyperTreeGrid to graphics primitives
	///
	/// vtkHyperTreeGridMapper is a class that maps polygonal data (i.e., vtkHyperTreeGrid)
	/// to graphics primitives. vtkHyperTreeGridMapper serves as a superclass for
	/// device-specific poly data mappers, that actually do the mapping to the
	/// rendering/graphics hardware/software.
	///
	/// By default, this class use an Adaptive GeometryFilter that extract only
	/// the part of the geometry to render. Be careful as this implies that new
	/// render my trigger an update of the pipeline to get the new part of the
	/// geometry to render.
	///
	/// Note: this class has its own module to avoid cyclic dependency between Rendering Core
	/// and Filters Hybrid
	/// * It need Filters Hybrid for Adaptive2DGeometryFilter
	/// * Filters Hybrid need Rendering Core because of Adaptive2DGeometryFilter
	/// </remarks>
	// Token: 0x020005B3 RID: 1459
	public class vtkHyperTreeGridMapper : vtkMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FFA9 RID: 65449 RVA: 0x00163BD7 File Offset: 0x00161DD7
		static vtkHyperTreeGridMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperTreeGridMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperTreeGridMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFAA RID: 65450 RVA: 0x00163BFF File Offset: 0x00161DFF
		public vtkHyperTreeGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FFAB RID: 65451
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFAC RID: 65452 RVA: 0x00163C10 File Offset: 0x00161E10
		public new static vtkHyperTreeGridMapper New()
		{
			vtkHyperTreeGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFAD RID: 65453 RVA: 0x00163C64 File Offset: 0x00161E64
		public vtkHyperTreeGridMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFAE RID: 65454 RVA: 0x00163CA8 File Offset: 0x00161EA8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FFAF RID: 65455
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridMapper_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		/// <summary>
		/// Fill the input port information objects for this algorithm.  This
		/// is invoked by the first call to GetInputPortInformation for each
		/// port so subclasses can specify what they can handle.
		/// </summary>
		// Token: 0x0600FFB0 RID: 65456 RVA: 0x00163CB4 File Offset: 0x00161EB4
		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0600FFB1 RID: 65457
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridMapper_GetBounds_02(HandleRef pThis);

		/// <summary>
		/// For this mapper, the bounds correspond to the output for the
		/// internal surface filter which may be restricted to the Camera frustum
		/// if UseCameraFrustum is on.
		/// </summary>
		// Token: 0x0600FFB2 RID: 65458 RVA: 0x00163CEC File Offset: 0x00161EEC
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600FFB3 RID: 65459
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_GetBounds_03(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// For this mapper, the bounds correspond to the output for the
		/// internal surface filter which may be restricted to the Camera frustum
		/// if UseCameraFrustum is on.
		/// </summary>
		// Token: 0x0600FFB4 RID: 65460 RVA: 0x00163D34 File Offset: 0x00161F34
		public override void GetBounds(IntPtr bounds)
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_GetBounds_03(base.GetCppThis(), bounds);
		}

		// Token: 0x0600FFB5 RID: 65461
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFB6 RID: 65462 RVA: 0x00163D44 File Offset: 0x00161F44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600FFB7 RID: 65463
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFB8 RID: 65464 RVA: 0x00163D64 File Offset: 0x00161F64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600FFB9 RID: 65465
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkHyperTreeGridMapper_GetUseAdaptiveDecimation_06(HandleRef pThis);

		/// <summary>
		/// This boolean control whether or not the mapping should adapt
		/// to the Camera frustum during the rendering. Setting this variable
		/// to true (default) should provide increased performances.
		/// </summary>
		// Token: 0x0600FFBA RID: 65466 RVA: 0x00163D80 File Offset: 0x00161F80
		public virtual bool GetUseAdaptiveDecimation()
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_GetUseAdaptiveDecimation_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FFBB RID: 65467
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridMapper_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFBC RID: 65468 RVA: 0x00163DA8 File Offset: 0x00161FA8
		public override int IsA(string type)
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600FFBD RID: 65469
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperTreeGridMapper_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFBE RID: 65470 RVA: 0x00163DC8 File Offset: 0x00161FC8
		public new static int IsTypeOf(string type)
		{
			return vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_IsTypeOf_08(type);
		}

		// Token: 0x0600FFBF RID: 65471
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridMapper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFC0 RID: 65472 RVA: 0x00163DE4 File Offset: 0x00161FE4
		public new vtkHyperTreeGridMapper NewInstance()
		{
			vtkHyperTreeGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FFC1 RID: 65473
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_Render_11(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Use the internal PolyData Mapper to do the rendering
		/// of the HTG transformed by the current SurfaceFilter:
		/// * Adaptive2DGeometryFilter if UseCameraFrustum
		/// * GeometryFilter otherwise
		/// </summary>
		// Token: 0x0600FFC2 RID: 65474 RVA: 0x00163E40 File Offset: 0x00162040
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_Render_11(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x0600FFC3 RID: 65475
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperTreeGridMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFC4 RID: 65476 RVA: 0x00163E84 File Offset: 0x00162084
		public new static vtkHyperTreeGridMapper SafeDownCast(vtkObjectBase o)
		{
			vtkHyperTreeGridMapper vtkHyperTreeGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperTreeGridMapper = (vtkHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperTreeGridMapper.Register(null);
				}
			}
			return vtkHyperTreeGridMapper;
		}

		// Token: 0x0600FFC5 RID: 65477
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_SetInputDataObject_13(HandleRef pThis, int port, HandleRef input);

		/// <summary>
		/// Set the connection for the given input port index.  Each input
		/// port of a filter has a specific purpose.  A port may have zero or
		/// more connections and the required number is specified by each
		/// filter.  Setting the connection with this method removes all
		/// other connections from the port.  To add more than one connection
		/// use AddInputConnection().
		/// The input for the connection is the output port of another
		/// filter, which is obtained with GetOutputPort().  Typical usage is
		/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x0600FFC6 RID: 65478 RVA: 0x00163F04 File Offset: 0x00162104
		public override void SetInputDataObject(int port, vtkDataObject input)
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_SetInputDataObject_13(base.GetCppThis(), port, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600FFC7 RID: 65479
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_SetInputDataObject_14(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the connection for the given input port index.  Each input
		/// port of a filter has a specific purpose.  A port may have zero or
		/// more connections and the required number is specified by each
		/// filter.  Setting the connection with this method removes all
		/// other connections from the port.  To add more than one connection
		/// use AddInputConnection().
		/// The input for the connection is the output port of another
		/// filter, which is obtained with GetOutputPort().  Typical usage is
		/// filter2-&gt;SetInputConnection(0, filter1-&gt;GetOutputPort(0)).
		/// </summary>
		// Token: 0x0600FFC8 RID: 65480 RVA: 0x00163F34 File Offset: 0x00162134
		public override void SetInputDataObject(vtkDataObject input)
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_SetInputDataObject_14(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600FFC9 RID: 65481
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_SetUseAdaptiveDecimation_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// This boolean control whether or not the mapping should adapt
		/// to the Camera frustum during the rendering. Setting this variable
		/// to true (default) should provide increased performances.
		/// </summary>
		// Token: 0x0600FFCA RID: 65482 RVA: 0x00163F63 File Offset: 0x00162163
		public virtual void SetUseAdaptiveDecimation(bool _arg)
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_SetUseAdaptiveDecimation_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FFCB RID: 65483
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_UseAdaptiveDecimationOff_16(HandleRef pThis);

		/// <summary>
		/// This boolean control whether or not the mapping should adapt
		/// to the Camera frustum during the rendering. Setting this variable
		/// to true (default) should provide increased performances.
		/// </summary>
		// Token: 0x0600FFCC RID: 65484 RVA: 0x00163F7B File Offset: 0x0016217B
		public virtual void UseAdaptiveDecimationOff()
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_UseAdaptiveDecimationOff_16(base.GetCppThis());
		}

		// Token: 0x0600FFCD RID: 65485
		[DllImport("Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperTreeGridMapper_UseAdaptiveDecimationOn_17(HandleRef pThis);

		/// <summary>
		/// This boolean control whether or not the mapping should adapt
		/// to the Camera frustum during the rendering. Setting this variable
		/// to true (default) should provide increased performances.
		/// </summary>
		// Token: 0x0600FFCE RID: 65486 RVA: 0x00163F8A File Offset: 0x0016218A
		public virtual void UseAdaptiveDecimationOn()
		{
			vtkHyperTreeGridMapper.vtkHyperTreeGridMapper_UseAdaptiveDecimationOn_17(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A8 RID: 4776
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperTreeGridMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012A9 RID: 4777
		public new static readonly string MRClassNameKey = "class vtkHyperTreeGridMapper";
	}
}
