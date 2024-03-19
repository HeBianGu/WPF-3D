using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSignedCharArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of signed char
	///
	/// vtkSignedCharArray is an array of values of type signed char.
	/// It provides methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	/// </remarks>
	// Token: 0x02000B29 RID: 2857
	public class vtkSignedCharArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DFC8 RID: 122824 RVA: 0x002A5715 File Offset: 0x002A3915
		static vtkSignedCharArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSignedCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSignedCharArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFC9 RID: 122825 RVA: 0x002A573D File Offset: 0x002A393D
		public vtkSignedCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DFCA RID: 122826
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFCB RID: 122827 RVA: 0x002A574C File Offset: 0x002A394C
		public new static vtkSignedCharArray New()
		{
			vtkSignedCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFCC RID: 122828 RVA: 0x002A57A0 File Offset: 0x002A39A0
		public vtkSignedCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSignedCharArray.vtkSignedCharArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DFCD RID: 122829 RVA: 0x002A57E4 File Offset: 0x002A39E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DFCE RID: 122830
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedCharArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFCF RID: 122831 RVA: 0x002A57F0 File Offset: 0x002A39F0
		public static vtkSignedCharArray ExtendedNew()
		{
			vtkSignedCharArray vtkSignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSignedCharArray = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSignedCharArray.Register(null);
				}
			}
			return vtkSignedCharArray;
		}

		// Token: 0x0601DFD0 RID: 122832
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedCharArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601DFD1 RID: 122833 RVA: 0x002A585C File Offset: 0x002A3A5C
		public new static vtkSignedCharArray FastDownCast(vtkAbstractArray source)
		{
			vtkSignedCharArray vtkSignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSignedCharArray = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSignedCharArray.Register(null);
				}
			}
			return vtkSignedCharArray;
		}

		// Token: 0x0601DFD2 RID: 122834
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkSignedCharArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601DFD3 RID: 122835 RVA: 0x002A58DC File Offset: 0x002A3ADC
		public static sbyte GetDataTypeValueMax()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601DFD4 RID: 122836
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkSignedCharArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601DFD5 RID: 122837 RVA: 0x002A58F8 File Offset: 0x002A3AF8
		public static sbyte GetDataTypeValueMin()
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601DFD6 RID: 122838
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSignedCharArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFD7 RID: 122839 RVA: 0x002A5914 File Offset: 0x002A3B14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601DFD8 RID: 122840
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSignedCharArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFD9 RID: 122841 RVA: 0x002A5934 File Offset: 0x002A3B34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601DFDA RID: 122842
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSignedCharArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFDB RID: 122843 RVA: 0x002A5950 File Offset: 0x002A3B50
		public override int IsA(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601DFDC RID: 122844
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSignedCharArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFDD RID: 122845 RVA: 0x002A5970 File Offset: 0x002A3B70
		public new static int IsTypeOf(string type)
		{
			return vtkSignedCharArray.vtkSignedCharArray_IsTypeOf_08(type);
		}

		// Token: 0x0601DFDE RID: 122846
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedCharArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFDF RID: 122847 RVA: 0x002A598C File Offset: 0x002A3B8C
		public new vtkSignedCharArray NewInstance()
		{
			vtkSignedCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DFE0 RID: 122848
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSignedCharArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DFE1 RID: 122849 RVA: 0x002A59E8 File Offset: 0x002A3BE8
		public new static vtkSignedCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkSignedCharArray vtkSignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSignedCharArray.vtkSignedCharArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSignedCharArray = (vtkSignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSignedCharArray.Register(null);
				}
			}
			return vtkSignedCharArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA1 RID: 8097
		public new const string MRFullTypeName = "Kitware.VTK.vtkSignedCharArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FA2 RID: 8098
		public new static readonly string MRClassNameKey = "class vtkSignedCharArray";
	}
}
