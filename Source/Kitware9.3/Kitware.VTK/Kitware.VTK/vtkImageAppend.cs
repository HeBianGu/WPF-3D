using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAppend
	/// </summary>
	/// <remarks>
	///    Collects data from multiple inputs into one image.
	///
	/// vtkImageAppend takes the components from multiple inputs and merges
	/// them into one output. The output images are append along the "AppendAxis".
	/// Except for the append axis, all inputs must have the same extent.
	/// All inputs must have the same number of scalar components.
	/// A future extension might be to pad or clip inputs to have the same extent.
	/// The output has the same origin and spacing as the first input.
	/// The origin and spacing of all other inputs are ignored.  All inputs
	/// must have the same scalar type.
	/// </remarks>
	// Token: 0x02000972 RID: 2418
	public class vtkImageAppend : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601937C RID: 103292 RVA: 0x002320B3 File Offset: 0x002302B3
		static vtkImageAppend()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAppend.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAppend"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601937D RID: 103293 RVA: 0x002320DB File Offset: 0x002302DB
		public vtkImageAppend(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601937E RID: 103294
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppend_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601937F RID: 103295 RVA: 0x002320EC File Offset: 0x002302EC
		public new static vtkImageAppend New()
		{
			vtkImageAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019380 RID: 103296 RVA: 0x00232140 File Offset: 0x00230340
		public vtkImageAppend() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageAppend.vtkImageAppend_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019381 RID: 103297 RVA: 0x00232184 File Offset: 0x00230384
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019382 RID: 103298
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppend_GetAppendAxis_01(HandleRef pThis);

		/// <summary>
		/// This axis is expanded to hold the multiple images.
		/// The default AppendAxis is the X axis.
		/// If you want to create a volue from a series of XY images, then you should
		/// set the AppendAxis to 2 (Z axis).
		/// </summary>
		// Token: 0x06019383 RID: 103299 RVA: 0x00232190 File Offset: 0x00230390
		public virtual int GetAppendAxis()
		{
			return vtkImageAppend.vtkImageAppend_GetAppendAxis_01(base.GetCppThis());
		}

		// Token: 0x06019384 RID: 103300
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppend_GetInput_02(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06019385 RID: 103301 RVA: 0x002321B0 File Offset: 0x002303B0
		public new vtkDataObject GetInput(int idx)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_GetInput_02(base.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019386 RID: 103302
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppend_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x06019387 RID: 103303 RVA: 0x00232220 File Offset: 0x00230420
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_GetInput_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06019388 RID: 103304
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAppend_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019389 RID: 103305 RVA: 0x00232290 File Offset: 0x00230490
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAppend.vtkImageAppend_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601938A RID: 103306
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAppend_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601938B RID: 103307 RVA: 0x002322B0 File Offset: 0x002304B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAppend.vtkImageAppend_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601938C RID: 103308
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppend_GetNumberOfInputs_06(HandleRef pThis);

		/// <summary>
		/// Get the number of inputs to this filter. This method is only for
		/// support of old-style pipeline connections.  When writing new code
		/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
		/// </summary>
		// Token: 0x0601938D RID: 103309 RVA: 0x002322CC File Offset: 0x002304CC
		public int GetNumberOfInputs()
		{
			return vtkImageAppend.vtkImageAppend_GetNumberOfInputs_06(base.GetCppThis());
		}

		// Token: 0x0601938E RID: 103310
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppend_GetPreserveExtents_07(HandleRef pThis);

		/// <summary>
		/// By default "PreserveExtents" is off and the append axis is used.
		/// When "PreseveExtents" is on, the extent of the inputs is used to
		/// place the image in the output.  The whole extent of the output is
		/// the union of the input whole extents.  Any portion of the
		/// output not covered by the inputs is set to zero.  The origin and
		/// spacing is taken from the first input.
		/// </summary>
		// Token: 0x0601938F RID: 103311 RVA: 0x002322EC File Offset: 0x002304EC
		public virtual int GetPreserveExtents()
		{
			return vtkImageAppend.vtkImageAppend_GetPreserveExtents_07(base.GetCppThis());
		}

		// Token: 0x06019390 RID: 103312
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppend_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019391 RID: 103313 RVA: 0x0023230C File Offset: 0x0023050C
		public override int IsA(string type)
		{
			return vtkImageAppend.vtkImageAppend_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06019392 RID: 103314
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppend_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019393 RID: 103315 RVA: 0x0023232C File Offset: 0x0023052C
		public new static int IsTypeOf(string type)
		{
			return vtkImageAppend.vtkImageAppend_IsTypeOf_09(type);
		}

		// Token: 0x06019394 RID: 103316
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppend_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019395 RID: 103317 RVA: 0x00232348 File Offset: 0x00230548
		public new vtkImageAppend NewInstance()
		{
			vtkImageAppend result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019396 RID: 103318
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_PreserveExtentsOff_12(HandleRef pThis);

		/// <summary>
		/// By default "PreserveExtents" is off and the append axis is used.
		/// When "PreseveExtents" is on, the extent of the inputs is used to
		/// place the image in the output.  The whole extent of the output is
		/// the union of the input whole extents.  Any portion of the
		/// output not covered by the inputs is set to zero.  The origin and
		/// spacing is taken from the first input.
		/// </summary>
		// Token: 0x06019397 RID: 103319 RVA: 0x002323A2 File Offset: 0x002305A2
		public virtual void PreserveExtentsOff()
		{
			vtkImageAppend.vtkImageAppend_PreserveExtentsOff_12(base.GetCppThis());
		}

		// Token: 0x06019398 RID: 103320
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_PreserveExtentsOn_13(HandleRef pThis);

		/// <summary>
		/// By default "PreserveExtents" is off and the append axis is used.
		/// When "PreseveExtents" is on, the extent of the inputs is used to
		/// place the image in the output.  The whole extent of the output is
		/// the union of the input whole extents.  Any portion of the
		/// output not covered by the inputs is set to zero.  The origin and
		/// spacing is taken from the first input.
		/// </summary>
		// Token: 0x06019399 RID: 103321 RVA: 0x002323B1 File Offset: 0x002305B1
		public virtual void PreserveExtentsOn()
		{
			vtkImageAppend.vtkImageAppend_PreserveExtentsOn_13(base.GetCppThis());
		}

		// Token: 0x0601939A RID: 103322
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_ReplaceNthInputConnection_14(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Replace one of the input connections with a new input.  You can
		/// only replace input connections that you previously created with
		/// AddInputConnection() or, in the case of the first input,
		/// with SetInputConnection().
		/// </summary>
		// Token: 0x0601939B RID: 103323 RVA: 0x002323C0 File Offset: 0x002305C0
		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageAppend.vtkImageAppend_ReplaceNthInputConnection_14(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601939C RID: 103324
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppend_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601939D RID: 103325 RVA: 0x002323F0 File Offset: 0x002305F0
		public new static vtkImageAppend SafeDownCast(vtkObjectBase o)
		{
			vtkImageAppend vtkImageAppend = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppend.vtkImageAppend_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAppend = (vtkImageAppend)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAppend.Register(null);
				}
			}
			return vtkImageAppend;
		}

		// Token: 0x0601939E RID: 103326
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_SetAppendAxis_16(HandleRef pThis, int _arg);

		/// <summary>
		/// This axis is expanded to hold the multiple images.
		/// The default AppendAxis is the X axis.
		/// If you want to create a volue from a series of XY images, then you should
		/// set the AppendAxis to 2 (Z axis).
		/// </summary>
		// Token: 0x0601939F RID: 103327 RVA: 0x0023246F File Offset: 0x0023066F
		public virtual void SetAppendAxis(int _arg)
		{
			vtkImageAppend.vtkImageAppend_SetAppendAxis_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060193A0 RID: 103328
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_SetInputData_17(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060193A1 RID: 103329 RVA: 0x00232480 File Offset: 0x00230680
		public new void SetInputData(int idx, vtkDataObject input)
		{
			vtkImageAppend.vtkImageAppend_SetInputData_17(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060193A2 RID: 103330
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_SetInputData_18(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x060193A3 RID: 103331 RVA: 0x002324B0 File Offset: 0x002306B0
		public new void SetInputData(vtkDataObject input)
		{
			vtkImageAppend.vtkImageAppend_SetInputData_18(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x060193A4 RID: 103332
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppend_SetPreserveExtents_19(HandleRef pThis, int _arg);

		/// <summary>
		/// By default "PreserveExtents" is off and the append axis is used.
		/// When "PreseveExtents" is on, the extent of the inputs is used to
		/// place the image in the output.  The whole extent of the output is
		/// the union of the input whole extents.  Any portion of the
		/// output not covered by the inputs is set to zero.  The origin and
		/// spacing is taken from the first input.
		/// </summary>
		// Token: 0x060193A5 RID: 103333 RVA: 0x002324DF File Offset: 0x002306DF
		public virtual void SetPreserveExtents(int _arg)
		{
			vtkImageAppend.vtkImageAppend_SetPreserveExtents_19(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B9D RID: 7069
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAppend";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B9E RID: 7070
		public new static readonly string MRClassNameKey = "class vtkImageAppend";
	}
}
