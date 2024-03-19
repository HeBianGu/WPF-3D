using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIntegerRequestKey
	/// </summary>
	/// <remarks>
	///    key that can used to request integer values from the pipeline
	/// vtkInformationIntegerRequestKey is a vtkInformationIntegerKey that can
	/// used to request integer values from upstream. A good example of this is
	/// UPDATE_NUMBER_OF_PIECES where downstream can request that upstream provides
	/// data partitioned into a certain number of pieces. There are several components
	/// that make this work. First, the key will copy itself upstream during
	/// REQUEST_UPDATE_EXTENT. Second, after a successful execution, it will stor
	/// its value into a data object's information using a specific key defined by
	/// its data member DataKey. Third, before execution, it will check if the requested
	/// value matched the value in the data object's information. If not, it will ask
	/// the pipeline to execute.
	///
	/// The best way to use this class is to subclass it to set the DataKey data member.
	/// This is usually done in the subclass' constructor.
	/// </remarks>
	// Token: 0x020009DD RID: 2525
	public class vtkInformationIntegerRequestKey : vtkInformationIntegerKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A48D RID: 107661 RVA: 0x00247A18 File Offset: 0x00245C18
		static vtkInformationIntegerRequestKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerRequestKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerRequestKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A48E RID: 107662 RVA: 0x00247A40 File Offset: 0x00245C40
		public vtkInformationIntegerRequestKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A48F RID: 107663 RVA: 0x00247A4E File Offset: 0x00245C4E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A490 RID: 107664
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerRequestKey_CopyDefaultInformation_01(HandleRef pThis, HandleRef request, HandleRef fromInfo, HandleRef toInfo);

		/// <summary>
		/// Copies the value stored in fromInfo using this key into toInfo
		/// if request has the REQUEST_UPDATE_EXTENT key.
		/// </summary>
		// Token: 0x0601A491 RID: 107665 RVA: 0x00247A5C File Offset: 0x00245C5C
		public override void CopyDefaultInformation(vtkInformation request, vtkInformation fromInfo, vtkInformation toInfo)
		{
			vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_CopyDefaultInformation_01(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (fromInfo == null) ? default(HandleRef) : fromInfo.GetCppThis(), (toInfo == null) ? default(HandleRef) : toInfo.GetCppThis());
		}

		// Token: 0x0601A492 RID: 107666
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A493 RID: 107667 RVA: 0x00247AB8 File Offset: 0x00245CB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A494 RID: 107668
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A495 RID: 107669 RVA: 0x00247AD8 File Offset: 0x00245CD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A496 RID: 107670
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerRequestKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A497 RID: 107671 RVA: 0x00247AF4 File Offset: 0x00245CF4
		public override int IsA(string type)
		{
			return vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A498 RID: 107672
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerRequestKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A499 RID: 107673 RVA: 0x00247B14 File Offset: 0x00245D14
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_IsTypeOf_05(type);
		}

		// Token: 0x0601A49A RID: 107674
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerRequestKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationIntegerRequestKey,
		/// given a name and a location. This method is provided for wrappers. Use
		/// the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A49B RID: 107675 RVA: 0x00247B30 File Offset: 0x00245D30
		public new static vtkInformationIntegerRequestKey MakeKey(string name, string location)
		{
			vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerRequestKey = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerRequestKey.Register(null);
				}
			}
			return vtkInformationIntegerRequestKey;
		}

		// Token: 0x0601A49C RID: 107676
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInformationIntegerRequestKey_NeedToExecute_07(HandleRef pThis, HandleRef pipelineInfo, HandleRef dobjInfo);

		/// <summary>
		/// Returns true if a value of type DataKey does not exist in dobjInfo
		/// or if it is different that the value stored in pipelineInfo using
		/// this key.
		/// </summary>
		// Token: 0x0601A49D RID: 107677 RVA: 0x00247B9C File Offset: 0x00245D9C
		public override bool NeedToExecute(vtkInformation pipelineInfo, vtkInformation dobjInfo)
		{
			return vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_NeedToExecute_07(base.GetCppThis(), (pipelineInfo == null) ? default(HandleRef) : pipelineInfo.GetCppThis(), (dobjInfo == null) ? default(HandleRef) : dobjInfo.GetCppThis()) != 0;
		}

		// Token: 0x0601A49E RID: 107678
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerRequestKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A49F RID: 107679 RVA: 0x00247BEC File Offset: 0x00245DEC
		public new vtkInformationIntegerRequestKey NewInstance()
		{
			vtkInformationIntegerRequestKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A4A0 RID: 107680
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerRequestKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A4A1 RID: 107681 RVA: 0x00247C48 File Offset: 0x00245E48
		public new static vtkInformationIntegerRequestKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerRequestKey = (vtkInformationIntegerRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerRequestKey.Register(null);
				}
			}
			return vtkInformationIntegerRequestKey;
		}

		// Token: 0x0601A4A2 RID: 107682
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerRequestKey_StoreMetaData_10(HandleRef pThis, HandleRef request, HandleRef pipelineInfo, HandleRef dobjInfo);

		/// <summary>
		/// Copies the value stored in pipelineInfo using this key into
		/// dobjInfo.
		/// </summary>
		// Token: 0x0601A4A3 RID: 107683 RVA: 0x00247CC8 File Offset: 0x00245EC8
		public override void StoreMetaData(vtkInformation request, vtkInformation pipelineInfo, vtkInformation dobjInfo)
		{
			vtkInformationIntegerRequestKey.vtkInformationIntegerRequestKey_StoreMetaData_10(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis(), (pipelineInfo == null) ? default(HandleRef) : pipelineInfo.GetCppThis(), (dobjInfo == null) ? default(HandleRef) : dobjInfo.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8A RID: 7306
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerRequestKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C8B RID: 7307
		public new static readonly string MRClassNameKey = "class vtkInformationIntegerRequestKey";
	}
}
