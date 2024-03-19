using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageAppendComponents
	/// </summary>
	/// <remarks>
	///    Collects components from two inputs into
	/// one output.
	///
	/// vtkImageAppendComponents takes the components from two inputs and merges
	/// them into one output. If Input1 has M components, and Input2 has N
	/// components, the output will have M+N components with input1
	/// components coming first.
	/// </remarks>
	// Token: 0x0200084C RID: 2124
	public class vtkImageAppendComponents : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016075 RID: 90229 RVA: 0x001F0536 File Offset: 0x001EE736
		static vtkImageAppendComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageAppendComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageAppendComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016076 RID: 90230 RVA: 0x001F055E File Offset: 0x001EE75E
		public vtkImageAppendComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016077 RID: 90231
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppendComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016078 RID: 90232 RVA: 0x001F056C File Offset: 0x001EE76C
		public new static vtkImageAppendComponents New()
		{
			vtkImageAppendComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016079 RID: 90233 RVA: 0x001F05C0 File Offset: 0x001EE7C0
		public vtkImageAppendComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageAppendComponents.vtkImageAppendComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601607A RID: 90234 RVA: 0x001F0604 File Offset: 0x001EE804
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601607B RID: 90235
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppendComponents_GetInput_01(HandleRef pThis, int num, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x0601607C RID: 90236 RVA: 0x001F0610 File Offset: 0x001EE810
		public new vtkDataObject GetInput(int num)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_GetInput_01(base.GetCppThis(), num, ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601607D RID: 90237
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppendComponents_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one input to this filter. This method is only for support of
		/// old-style pipeline connections.  When writing new code you should
		/// use vtkAlgorithm::GetInputConnection(0, num).
		/// </summary>
		// Token: 0x0601607E RID: 90238 RVA: 0x001F0680 File Offset: 0x001EE880
		public new vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601607F RID: 90239
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAppendComponents_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016080 RID: 90240 RVA: 0x001F06F0 File Offset: 0x001EE8F0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016081 RID: 90241
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageAppendComponents_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016082 RID: 90242 RVA: 0x001F0710 File Offset: 0x001EE910
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016083 RID: 90243
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppendComponents_GetNumberOfInputs_05(HandleRef pThis);

		/// <summary>
		/// Get the number of inputs to this filter. This method is only for
		/// support of old-style pipeline connections.  When writing new code
		/// you should use vtkAlgorithm::GetNumberOfInputConnections(0).
		/// </summary>
		// Token: 0x06016084 RID: 90244 RVA: 0x001F072C File Offset: 0x001EE92C
		public int GetNumberOfInputs()
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_GetNumberOfInputs_05(base.GetCppThis());
		}

		// Token: 0x06016085 RID: 90245
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppendComponents_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016086 RID: 90246 RVA: 0x001F074C File Offset: 0x001EE94C
		public override int IsA(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06016087 RID: 90247
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageAppendComponents_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016088 RID: 90248 RVA: 0x001F076C File Offset: 0x001EE96C
		public new static int IsTypeOf(string type)
		{
			return vtkImageAppendComponents.vtkImageAppendComponents_IsTypeOf_07(type);
		}

		// Token: 0x06016089 RID: 90249
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppendComponents_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601608A RID: 90250 RVA: 0x001F0788 File Offset: 0x001EE988
		public new vtkImageAppendComponents NewInstance()
		{
			vtkImageAppendComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601608B RID: 90251
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppendComponents_ReplaceNthInputConnection_10(HandleRef pThis, int idx, HandleRef input);

		/// <summary>
		/// Replace one of the input connections with a new input.  You can
		/// only replace input connections that you previously created with
		/// AddInputConnection() or, in the case of the first input,
		/// with SetInputConnection().
		/// </summary>
		// Token: 0x0601608C RID: 90252 RVA: 0x001F07E4 File Offset: 0x001EE9E4
		public virtual void ReplaceNthInputConnection(int idx, vtkAlgorithmOutput input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_ReplaceNthInputConnection_10(base.GetCppThis(), idx, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0601608D RID: 90253
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageAppendComponents_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601608E RID: 90254 RVA: 0x001F0814 File Offset: 0x001EEA14
		public new static vtkImageAppendComponents SafeDownCast(vtkObjectBase o)
		{
			vtkImageAppendComponents vtkImageAppendComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageAppendComponents.vtkImageAppendComponents_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageAppendComponents = (vtkImageAppendComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageAppendComponents.Register(null);
				}
			}
			return vtkImageAppendComponents;
		}

		// Token: 0x0601608F RID: 90255
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppendComponents_SetInputData_12(HandleRef pThis, int num, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06016090 RID: 90256 RVA: 0x001F0894 File Offset: 0x001EEA94
		public new void SetInputData(int num, vtkDataObject input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_SetInputData_12(base.GetCppThis(), num, (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06016091 RID: 90257
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageAppendComponents_SetInputData_13(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Assign a data object as input. Note that this method does not
		/// establish a pipeline connection. Use SetInputConnection() to
		/// setup a pipeline connection.
		/// </summary>
		// Token: 0x06016092 RID: 90258 RVA: 0x001F08C4 File Offset: 0x001EEAC4
		public new void SetInputData(vtkDataObject input)
		{
			vtkImageAppendComponents.vtkImageAppendComponents_SetInputData_13(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018EC RID: 6380
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageAppendComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018ED RID: 6381
		public new static readonly string MRClassNameKey = "class vtkImageAppendComponents";
	}
}
