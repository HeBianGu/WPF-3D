using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEnsembleSource
	/// </summary>
	/// <remarks>
	///    source that manages dataset ensembles
	///
	/// vtkEnsembleSource manages a collection of data sources in order to
	/// represent a dataset ensemble. It has the ability to provide meta-data
	/// about the ensemble in the form of a table, using the META_DATA key
	/// as well as accept a pipeline request using the UPDATE_MEMBER key.
	/// Note that it is expected that all ensemble members produce data of the
	/// same type.
	/// </remarks>
	// Token: 0x020009CC RID: 2508
	public class vtkEnsembleSource : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A2B0 RID: 107184 RVA: 0x00244737 File Offset: 0x00242937
		static vtkEnsembleSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnsembleSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnsembleSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2B1 RID: 107185 RVA: 0x0024475F File Offset: 0x0024295F
		public vtkEnsembleSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A2B2 RID: 107186
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnsembleSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2B3 RID: 107187 RVA: 0x00244770 File Offset: 0x00242970
		public new static vtkEnsembleSource New()
		{
			vtkEnsembleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnsembleSource.vtkEnsembleSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2B4 RID: 107188 RVA: 0x002447C4 File Offset: 0x002429C4
		public vtkEnsembleSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEnsembleSource.vtkEnsembleSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2B5 RID: 107189 RVA: 0x00244808 File Offset: 0x00242A08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A2B6 RID: 107190
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnsembleSource_AddMember_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add an algorithm (source) that will produce the next ensemble member.
		/// This algorithm will be passed the REQUEST_INFORMATION, REQUEST_UPDATE_EXTENT
		/// and REQUEST_DATA pipeline passes for execution.
		/// </summary>
		// Token: 0x0601A2B7 RID: 107191 RVA: 0x00244814 File Offset: 0x00242A14
		public void AddMember(vtkAlgorithm arg0)
		{
			vtkEnsembleSource.vtkEnsembleSource_AddMember_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A2B8 RID: 107192
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkEnsembleSource_GetCurrentMember_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the current ensemble member to process. Note that this data member
		/// will not be used if the UPDATE_MEMBER key is present in the pipeline. Also,
		/// this data member may be removed in the future. Unless it is absolutely necessary
		/// to use this data member, use the UPDATE_MEMBER key instead.
		/// </summary>
		// Token: 0x0601A2B9 RID: 107193 RVA: 0x00244844 File Offset: 0x00242A44
		public virtual uint GetCurrentMember()
		{
			return vtkEnsembleSource.vtkEnsembleSource_GetCurrentMember_02(base.GetCppThis());
		}

		// Token: 0x0601A2BA RID: 107194
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnsembleSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2BB RID: 107195 RVA: 0x00244864 File Offset: 0x00242A64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEnsembleSource.vtkEnsembleSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A2BC RID: 107196
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEnsembleSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2BD RID: 107197 RVA: 0x00244884 File Offset: 0x00242A84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEnsembleSource.vtkEnsembleSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601A2BE RID: 107198
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkEnsembleSource_GetNumberOfMembers_05(HandleRef pThis);

		/// <summary>
		/// Returns the number of ensemble members.
		/// </summary>
		// Token: 0x0601A2BF RID: 107199 RVA: 0x002448A0 File Offset: 0x00242AA0
		public uint GetNumberOfMembers()
		{
			return vtkEnsembleSource.vtkEnsembleSource_GetNumberOfMembers_05(base.GetCppThis());
		}

		// Token: 0x0601A2C0 RID: 107200
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnsembleSource_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2C1 RID: 107201 RVA: 0x002448C0 File Offset: 0x00242AC0
		public override int IsA(string type)
		{
			return vtkEnsembleSource.vtkEnsembleSource_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A2C2 RID: 107202
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEnsembleSource_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2C3 RID: 107203 RVA: 0x002448E0 File Offset: 0x00242AE0
		public new static int IsTypeOf(string type)
		{
			return vtkEnsembleSource.vtkEnsembleSource_IsTypeOf_07(type);
		}

		// Token: 0x0601A2C4 RID: 107204
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnsembleSource_META_DATA_08(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Meta-data for the ensemble. This is set with SetMetaData.
		/// </summary>
		// Token: 0x0601A2C5 RID: 107205 RVA: 0x002448FC File Offset: 0x00242AFC
		public static vtkInformationDataObjectMetaDataKey META_DATA()
		{
			vtkInformationDataObjectMetaDataKey vtkInformationDataObjectMetaDataKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnsembleSource.vtkEnsembleSource_META_DATA_08(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectMetaDataKey = (vtkInformationDataObjectMetaDataKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectMetaDataKey.Register(null);
				}
			}
			return vtkInformationDataObjectMetaDataKey;
		}

		// Token: 0x0601A2C6 RID: 107206
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnsembleSource_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2C7 RID: 107207 RVA: 0x00244968 File Offset: 0x00242B68
		public new vtkEnsembleSource NewInstance()
		{
			vtkEnsembleSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnsembleSource.vtkEnsembleSource_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A2C8 RID: 107208
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnsembleSource_RemoveAllMembers_11(HandleRef pThis);

		/// <summary>
		/// Removes all ensemble members.
		/// </summary>
		// Token: 0x0601A2C9 RID: 107209 RVA: 0x002449C2 File Offset: 0x00242BC2
		public void RemoveAllMembers()
		{
			vtkEnsembleSource.vtkEnsembleSource_RemoveAllMembers_11(base.GetCppThis());
		}

		// Token: 0x0601A2CA RID: 107210
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnsembleSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2CB RID: 107211 RVA: 0x002449D4 File Offset: 0x00242BD4
		public new static vtkEnsembleSource SafeDownCast(vtkObjectBase o)
		{
			vtkEnsembleSource vtkEnsembleSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnsembleSource.vtkEnsembleSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnsembleSource = (vtkEnsembleSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnsembleSource.Register(null);
				}
			}
			return vtkEnsembleSource;
		}

		// Token: 0x0601A2CC RID: 107212
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnsembleSource_SetCurrentMember_13(HandleRef pThis, uint _arg);

		/// <summary>
		/// Set/Get the current ensemble member to process. Note that this data member
		/// will not be used if the UPDATE_MEMBER key is present in the pipeline. Also,
		/// this data member may be removed in the future. Unless it is absolutely necessary
		/// to use this data member, use the UPDATE_MEMBER key instead.
		/// </summary>
		// Token: 0x0601A2CD RID: 107213 RVA: 0x00244A53 File Offset: 0x00242C53
		public virtual void SetCurrentMember(uint _arg)
		{
			vtkEnsembleSource.vtkEnsembleSource_SetCurrentMember_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A2CE RID: 107214
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEnsembleSource_SetMetaData_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the meta-data that will be propagated downstream. Make sure that this table
		/// has as many rows as the ensemble members and the meta-data for each row matches
		/// the corresponding ensemble source.
		/// </summary>
		// Token: 0x0601A2CF RID: 107215 RVA: 0x00244A64 File Offset: 0x00242C64
		public void SetMetaData(vtkTable arg0)
		{
			vtkEnsembleSource.vtkEnsembleSource_SetMetaData_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601A2D0 RID: 107216
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEnsembleSource_UPDATE_MEMBER_15(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Key used to request a particular ensemble member.
		/// </summary>
		// Token: 0x0601A2D1 RID: 107217 RVA: 0x00244A94 File Offset: 0x00242C94
		public static vtkInformationIntegerRequestKey UPDATE_MEMBER()
		{
			vtkInformationIntegerRequestKey vtkInformationIntegerRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEnsembleSource.vtkEnsembleSource_UPDATE_MEMBER_15(ref mteStatus, ref maxValue, ref rawRefCount);
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

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C65 RID: 7269
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnsembleSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C66 RID: 7270
		public new static readonly string MRClassNameKey = "class vtkEnsembleSource";
	}
}
