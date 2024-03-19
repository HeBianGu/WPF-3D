using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCharArray
	/// </summary>
	/// <remarks>
	///    dynamic, self-adjusting array of char
	///
	/// vtkCharArray is an array of values of type char.  It provides
	/// methods for insertion and retrieval of values and will
	/// automatically resize itself to hold new data.
	///
	/// @warning
	/// This class should be avoided in favor of either
	/// vtkSignedCharArray or vtkUnsignedCharArray. On some systems
	/// the underlying data will be stored as unsigned chars and others
	/// it will be stored as signed chars. Additionally, saving this
	/// array out and then reading it back in it could be transformed to
	/// a vtkSignedCharArray or vtkUnsignedCharArray and if that happens
	/// the result of a vtkCharArray::SafeDownCast() of that pointer will be
	/// a null pointer.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSignedCharArray vtkUnsignedCharArray
	/// </seealso>
	// Token: 0x02000B48 RID: 2888
	public class vtkCharArray : vtkDataArray
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E314 RID: 123668 RVA: 0x002AB3F5 File Offset: 0x002A95F5
		static vtkCharArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCharArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCharArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E315 RID: 123669 RVA: 0x002AB41D File Offset: 0x002A961D
		public vtkCharArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E316 RID: 123670
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCharArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E317 RID: 123671 RVA: 0x002AB42C File Offset: 0x002A962C
		public new static vtkCharArray New()
		{
			vtkCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCharArray.vtkCharArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E318 RID: 123672 RVA: 0x002AB480 File Offset: 0x002A9680
		public vtkCharArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCharArray.vtkCharArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E319 RID: 123673 RVA: 0x002AB4C4 File Offset: 0x002A96C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E31A RID: 123674
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCharArray_ExtendedNew_01(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E31B RID: 123675 RVA: 0x002AB4D0 File Offset: 0x002A96D0
		public static vtkCharArray ExtendedNew()
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCharArray.vtkCharArray_ExtendedNew_01(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		// Token: 0x0601E31C RID: 123676
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCharArray_FastDownCast_02(HandleRef source, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// A faster alternative to SafeDownCast for downcasting vtkAbstractArrays.
		/// </summary>
		// Token: 0x0601E31D RID: 123677 RVA: 0x002AB53C File Offset: 0x002A973C
		public new static vtkCharArray FastDownCast(vtkAbstractArray source)
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCharArray.vtkCharArray_FastDownCast_02((source == null) ? default(HandleRef) : source.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		// Token: 0x0601E31E RID: 123678
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkCharArray_GetDataTypeValueMax_03();

		/// <summary>
		/// Get the maximum data value in its native type.
		/// </summary>
		// Token: 0x0601E31F RID: 123679 RVA: 0x002AB5BC File Offset: 0x002A97BC
		public static sbyte GetDataTypeValueMax()
		{
			return vtkCharArray.vtkCharArray_GetDataTypeValueMax_03();
		}

		// Token: 0x0601E320 RID: 123680
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern sbyte vtkCharArray_GetDataTypeValueMin_04();

		/// <summary>
		/// Get the minimum data value in its native type.
		/// </summary>
		// Token: 0x0601E321 RID: 123681 RVA: 0x002AB5D8 File Offset: 0x002A97D8
		public static sbyte GetDataTypeValueMin()
		{
			return vtkCharArray.vtkCharArray_GetDataTypeValueMin_04();
		}

		// Token: 0x0601E322 RID: 123682
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCharArray_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E323 RID: 123683 RVA: 0x002AB5F4 File Offset: 0x002A97F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCharArray.vtkCharArray_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E324 RID: 123684
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCharArray_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E325 RID: 123685 RVA: 0x002AB614 File Offset: 0x002A9814
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCharArray.vtkCharArray_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E326 RID: 123686
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCharArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E327 RID: 123687 RVA: 0x002AB630 File Offset: 0x002A9830
		public override int IsA(string type)
		{
			return vtkCharArray.vtkCharArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E328 RID: 123688
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCharArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E329 RID: 123689 RVA: 0x002AB650 File Offset: 0x002A9850
		public new static int IsTypeOf(string type)
		{
			return vtkCharArray.vtkCharArray_IsTypeOf_08(type);
		}

		// Token: 0x0601E32A RID: 123690
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCharArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E32B RID: 123691 RVA: 0x002AB66C File Offset: 0x002A986C
		public new vtkCharArray NewInstance()
		{
			vtkCharArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCharArray.vtkCharArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E32C RID: 123692
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCharArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E32D RID: 123693 RVA: 0x002AB6C8 File Offset: 0x002A98C8
		public new static vtkCharArray SafeDownCast(vtkObjectBase o)
		{
			vtkCharArray vtkCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCharArray.vtkCharArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCharArray = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCharArray.Register(null);
				}
			}
			return vtkCharArray;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE3 RID: 8163
		public new const string MRFullTypeName = "Kitware.VTK.vtkCharArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001FE4 RID: 8164
		public new static readonly string MRClassNameKey = "class vtkCharArray";
	}
}
