using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLookupTableWithEnabling
	/// </summary>
	/// <remarks>
	///    A lookup table that allows for an
	/// optional array to be provided that specifies which scalars to "enable" and
	/// which to "disable".
	///
	///
	/// vtkLookupTableWithEnabling "disables" or "grays out" output colors
	/// based on whether the given value in EnabledArray is "0" or not.
	///
	///
	/// @warning
	/// You must set the EnabledArray before MapScalars() is called.
	/// Indices of EnabledArray must map directly to those of the array passed
	/// to MapScalars().
	///
	/// </remarks>
	// Token: 0x020007F2 RID: 2034
	public class vtkLookupTableWithEnabling : vtkLookupTable
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014E98 RID: 85656 RVA: 0x001D93BF File Offset: 0x001D75BF
		static vtkLookupTableWithEnabling()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLookupTableWithEnabling.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLookupTableWithEnabling"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014E99 RID: 85657 RVA: 0x001D93E7 File Offset: 0x001D75E7
		public vtkLookupTableWithEnabling(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014E9A RID: 85658
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableWithEnabling_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E9B RID: 85659 RVA: 0x001D93F8 File Offset: 0x001D75F8
		public new static vtkLookupTableWithEnabling New()
		{
			vtkLookupTableWithEnabling result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014E9C RID: 85660 RVA: 0x001D944C File Offset: 0x001D764C
		public vtkLookupTableWithEnabling() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014E9D RID: 85661 RVA: 0x001D9490 File Offset: 0x001D7690
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014E9E RID: 85662
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTableWithEnabling_DisableColor_01(HandleRef pThis, byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd);

		/// <summary>
		/// A convenience method for taking a color and desaturating it.
		/// </summary>
		// Token: 0x06014E9F RID: 85663 RVA: 0x001D949B File Offset: 0x001D769B
		public virtual void DisableColor(byte r, byte g, byte b, IntPtr rd, IntPtr gd, IntPtr bd)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_DisableColor_01(base.GetCppThis(), r, g, b, rd, gd, bd);
		}

		// Token: 0x06014EA0 RID: 85664
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableWithEnabling_GetEnabledArray_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This must be set before MapScalars() is called.
		/// Indices of this array must map directly to those in the scalars array
		/// passed to MapScalars().
		/// Values of 0 in the array indicate the color should be desaturatated.
		/// </summary>
		// Token: 0x06014EA1 RID: 85665 RVA: 0x001D94B4 File Offset: 0x001D76B4
		public virtual vtkDataArray GetEnabledArray()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_GetEnabledArray_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x06014EA2 RID: 85666
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EA3 RID: 85667 RVA: 0x001D9524 File Offset: 0x001D7724
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014EA4 RID: 85668
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EA5 RID: 85669 RVA: 0x001D9544 File Offset: 0x001D7744
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014EA6 RID: 85670
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTableWithEnabling_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EA7 RID: 85671 RVA: 0x001D9560 File Offset: 0x001D7760
		public override int IsA(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06014EA8 RID: 85672
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLookupTableWithEnabling_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EA9 RID: 85673 RVA: 0x001D9580 File Offset: 0x001D7780
		public new static int IsTypeOf(string type)
		{
			return vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_IsTypeOf_06(type);
		}

		// Token: 0x06014EAA RID: 85674
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTableWithEnabling_MapScalarsThroughTable2_07(HandleRef pThis, IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat);

		/// <summary>
		/// Map a set of scalars through the lookup table.
		/// </summary>
		// Token: 0x06014EAB RID: 85675 RVA: 0x001D959A File Offset: 0x001D779A
		public override void MapScalarsThroughTable2(IntPtr input, IntPtr output, int inputDataType, int numberOfValues, int inputIncrement, int outputFormat)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_MapScalarsThroughTable2_07(base.GetCppThis(), input, output, inputDataType, numberOfValues, inputIncrement, outputFormat);
		}

		// Token: 0x06014EAC RID: 85676
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableWithEnabling_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EAD RID: 85677 RVA: 0x001D95B4 File Offset: 0x001D77B4
		public new vtkLookupTableWithEnabling NewInstance()
		{
			vtkLookupTableWithEnabling result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014EAE RID: 85678
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLookupTableWithEnabling_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014EAF RID: 85679 RVA: 0x001D9610 File Offset: 0x001D7810
		public new static vtkLookupTableWithEnabling SafeDownCast(vtkObjectBase o)
		{
			vtkLookupTableWithEnabling vtkLookupTableWithEnabling = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTableWithEnabling = (vtkLookupTableWithEnabling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTableWithEnabling.Register(null);
				}
			}
			return vtkLookupTableWithEnabling;
		}

		// Token: 0x06014EB0 RID: 85680
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLookupTableWithEnabling_SetEnabledArray_11(HandleRef pThis, HandleRef enabledArray);

		/// <summary>
		/// This must be set before MapScalars() is called.
		/// Indices of this array must map directly to those in the scalars array
		/// passed to MapScalars().
		/// Values of 0 in the array indicate the color should be desaturatated.
		/// </summary>
		// Token: 0x06014EB1 RID: 85681 RVA: 0x001D9690 File Offset: 0x001D7890
		public virtual void SetEnabledArray(vtkDataArray enabledArray)
		{
			vtkLookupTableWithEnabling.vtkLookupTableWithEnabling_SetEnabledArray_11(base.GetCppThis(), (enabledArray == null) ? default(HandleRef) : enabledArray.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001823 RID: 6179
		public new const string MRFullTypeName = "Kitware.VTK.vtkLookupTableWithEnabling";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001824 RID: 6180
		public new static readonly string MRClassNameKey = "class vtkLookupTableWithEnabling";
	}
}
