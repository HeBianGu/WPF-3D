using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkIdTypeArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of vtkIdType
	///
	/// vtkIdTypeArray is an array of values of type vtkIdType.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	/// </remarks>
	// Token: 0x02000B57 RID: 2903
	public class vtkIdTypeArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E4FA RID: 124154 RVA: 0x002AE107 File Offset: 0x002AC307
		static vtkIdTypeArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkIdTypeArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkIdTypeArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E4FB RID: 124155 RVA: 0x002AE12F File Offset: 0x002AC32F
		public vtkIdTypeArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E4FC RID: 124156
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdTypeArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4FD RID: 124157 RVA: 0x002AE140 File Offset: 0x002AC340
		public new static vtkIdTypeArray New()
		{
			vtkIdTypeArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdTypeArray.vtkIdTypeArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E4FE RID: 124158 RVA: 0x002AE194 File Offset: 0x002AC394
		public vtkIdTypeArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkIdTypeArray.vtkIdTypeArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E4FF RID: 124159 RVA: 0x002AE1D8 File Offset: 0x002AC3D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E500 RID: 124160
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdTypeArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E501 RID: 124161 RVA: 0x002AE1E4 File Offset: 0x002AC3E4
		public static vtkIdTypeArray ExtendedNew()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdTypeArray.vtkIdTypeArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601E502 RID: 124162
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdTypeArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E503 RID: 124163 RVA: 0x002AE250 File Offset: 0x002AC450
		public new static vtkIdTypeArray FastDownCast(vtkAbstractArray source)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdTypeArray.vtkIdTypeArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x0601E504 RID: 124164
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdTypeArray_GetDataType_03(HandleRef pThis);

		/// <summary>
		/// Get the data type.
		/// </summary>
		// Token: 0x0601E505 RID: 124165 RVA: 0x002AE2D0 File Offset: 0x002AC4D0
		public override int GetDataType()
		{
			return vtkIdTypeArray.vtkIdTypeArray_GetDataType_03(base.GetCppThis());
		}

		// Token: 0x0601E506 RID: 124166
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdTypeArray_GetDataTypeValueMax_04();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E507 RID: 124167 RVA: 0x002AE2F0 File Offset: 0x002AC4F0
		public static long GetDataTypeValueMax()
		{
			return vtkIdTypeArray.vtkIdTypeArray_GetDataTypeValueMax_04();
		}

		// Token: 0x0601E508 RID: 124168
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdTypeArray_GetDataTypeValueMin_05();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E509 RID: 124169 RVA: 0x002AE30C File Offset: 0x002AC50C
		public static long GetDataTypeValueMin()
		{
			return vtkIdTypeArray.vtkIdTypeArray_GetDataTypeValueMin_05();
		}

		// Token: 0x0601E50A RID: 124170
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdTypeArray_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E50B RID: 124171 RVA: 0x002AE328 File Offset: 0x002AC528
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkIdTypeArray.vtkIdTypeArray_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601E50C RID: 124172
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkIdTypeArray_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E50D RID: 124173 RVA: 0x002AE348 File Offset: 0x002AC548
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkIdTypeArray.vtkIdTypeArray_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601E50E RID: 124174
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdTypeArray_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E50F RID: 124175 RVA: 0x002AE364 File Offset: 0x002AC564
		public override int IsA(string type)
		{
			return vtkIdTypeArray.vtkIdTypeArray_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E510 RID: 124176
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkIdTypeArray_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E511 RID: 124177 RVA: 0x002AE384 File Offset: 0x002AC584
		public new static int IsTypeOf(string type)
		{
			return vtkIdTypeArray.vtkIdTypeArray_IsTypeOf_09(type);
		}

		// Token: 0x0601E512 RID: 124178
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdTypeArray_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E513 RID: 124179 RVA: 0x002AE3A0 File Offset: 0x002AC5A0
		public new vtkIdTypeArray NewInstance()
		{
			vtkIdTypeArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdTypeArray.vtkIdTypeArray_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E514 RID: 124180
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkIdTypeArray_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E515 RID: 124181 RVA: 0x002AE3FC File Offset: 0x002AC5FC
		public new static vtkIdTypeArray SafeDownCast(vtkObjectBase o)
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkIdTypeArray.vtkIdTypeArray_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208D RID: 8333
		public new const string MRFullTypeName = "Kitware.VTK.vtkIdTypeArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208E RID: 8334
		public new static readonly string MRClassNameKey = "class vtkIdTypeArray";
	}
}
