using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiagonalMatrixSource
	/// </summary>
	/// <remarks>
	///    generates a sparse or dense square matrix
	/// with user-specified values for the diagonal, superdiagonal, and subdiagonal.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000825 RID: 2085
	public class vtkDiagonalMatrixSource : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601586E RID: 88174 RVA: 0x001E6DD1 File Offset: 0x001E4FD1
		static vtkDiagonalMatrixSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiagonalMatrixSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiagonalMatrixSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601586F RID: 88175 RVA: 0x001E6DF9 File Offset: 0x001E4FF9
		public vtkDiagonalMatrixSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015870 RID: 88176
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiagonalMatrixSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015871 RID: 88177 RVA: 0x001E6E08 File Offset: 0x001E5008
		public new static vtkDiagonalMatrixSource New()
		{
			vtkDiagonalMatrixSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015872 RID: 88178 RVA: 0x001E6E5C File Offset: 0x001E505C
		public vtkDiagonalMatrixSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015873 RID: 88179 RVA: 0x001E6EA0 File Offset: 0x001E50A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015874 RID: 88180
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiagonalMatrixSource_GetArrayType_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015875 RID: 88181 RVA: 0x001E6EAC File Offset: 0x001E50AC
		public virtual int GetArrayType()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetArrayType_01(base.GetCppThis());
		}

		// Token: 0x06015876 RID: 88182
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiagonalMatrixSource_GetColumnLabel_02(HandleRef pThis);

		/// <summary>
		/// Controls the output matrix column dimension label.
		/// Default: "columns"
		/// </summary>
		// Token: 0x06015877 RID: 88183 RVA: 0x001E6ECC File Offset: 0x001E50CC
		public virtual string GetColumnLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetColumnLabel_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015878 RID: 88184
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiagonalMatrixSource_GetDiagonal_03(HandleRef pThis);

		/// <summary>
		/// Stores the value that will be assigned to diagonal elements (default: 1)
		/// </summary>
		// Token: 0x06015879 RID: 88185 RVA: 0x001E6F08 File Offset: 0x001E5108
		public virtual double GetDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetDiagonal_03(base.GetCppThis());
		}

		// Token: 0x0601587A RID: 88186
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiagonalMatrixSource_GetExtents_04(HandleRef pThis);

		/// <summary>
		/// Stores the extents of the output matrix (which is square)
		/// </summary>
		// Token: 0x0601587B RID: 88187 RVA: 0x001E6F28 File Offset: 0x001E5128
		public virtual long GetExtents()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetExtents_04(base.GetCppThis());
		}

		// Token: 0x0601587C RID: 88188
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601587D RID: 88189 RVA: 0x001E6F48 File Offset: 0x001E5148
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601587E RID: 88190
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601587F RID: 88191 RVA: 0x001E6F68 File Offset: 0x001E5168
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06015880 RID: 88192
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiagonalMatrixSource_GetRowLabel_07(HandleRef pThis);

		/// <summary>
		/// Controls the output matrix row dimension label.
		/// Default: "rows"
		/// </summary>
		// Token: 0x06015881 RID: 88193 RVA: 0x001E6F84 File Offset: 0x001E5184
		public virtual string GetRowLabel()
		{
			string s = Marshal.PtrToStringAnsi(vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetRowLabel_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06015882 RID: 88194
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiagonalMatrixSource_GetSubDiagonal_08(HandleRef pThis);

		/// <summary>
		/// Stores the value that will be assigned to subdiagonal elements (default: 0)
		/// </summary>
		// Token: 0x06015883 RID: 88195 RVA: 0x001E6FC0 File Offset: 0x001E51C0
		public virtual double GetSubDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetSubDiagonal_08(base.GetCppThis());
		}

		// Token: 0x06015884 RID: 88196
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDiagonalMatrixSource_GetSuperDiagonal_09(HandleRef pThis);

		/// <summary>
		/// Stores the value that will be assigned to superdiagonal elements (default: 0)
		/// </summary>
		// Token: 0x06015885 RID: 88197 RVA: 0x001E6FE0 File Offset: 0x001E51E0
		public virtual double GetSuperDiagonal()
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_GetSuperDiagonal_09(base.GetCppThis());
		}

		// Token: 0x06015886 RID: 88198
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiagonalMatrixSource_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015887 RID: 88199 RVA: 0x001E7000 File Offset: 0x001E5200
		public override int IsA(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06015888 RID: 88200
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiagonalMatrixSource_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015889 RID: 88201 RVA: 0x001E7020 File Offset: 0x001E5220
		public new static int IsTypeOf(string type)
		{
			return vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_IsTypeOf_11(type);
		}

		// Token: 0x0601588A RID: 88202
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiagonalMatrixSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601588B RID: 88203 RVA: 0x001E703C File Offset: 0x001E523C
		public new vtkDiagonalMatrixSource NewInstance()
		{
			vtkDiagonalMatrixSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601588C RID: 88204
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiagonalMatrixSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601588D RID: 88205 RVA: 0x001E7098 File Offset: 0x001E5298
		public new static vtkDiagonalMatrixSource SafeDownCast(vtkObjectBase o)
		{
			vtkDiagonalMatrixSource vtkDiagonalMatrixSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiagonalMatrixSource = (vtkDiagonalMatrixSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiagonalMatrixSource.Register(null);
				}
			}
			return vtkDiagonalMatrixSource;
		}

		// Token: 0x0601588E RID: 88206
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetArrayType_15(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601588F RID: 88207 RVA: 0x001E7117 File Offset: 0x001E5317
		public virtual void SetArrayType(int _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetArrayType_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06015890 RID: 88208
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetColumnLabel_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Controls the output matrix column dimension label.
		/// Default: "columns"
		/// </summary>
		// Token: 0x06015891 RID: 88209 RVA: 0x001E7127 File Offset: 0x001E5327
		public virtual void SetColumnLabel(string _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetColumnLabel_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06015892 RID: 88210
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetDiagonal_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Stores the value that will be assigned to diagonal elements (default: 1)
		/// </summary>
		// Token: 0x06015893 RID: 88211 RVA: 0x001E7137 File Offset: 0x001E5337
		public virtual void SetDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetDiagonal_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06015894 RID: 88212
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetExtents_18(HandleRef pThis, long _arg);

		/// <summary>
		/// Stores the extents of the output matrix (which is square)
		/// </summary>
		// Token: 0x06015895 RID: 88213 RVA: 0x001E7147 File Offset: 0x001E5347
		public virtual void SetExtents(long _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetExtents_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06015896 RID: 88214
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetRowLabel_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Controls the output matrix row dimension label.
		/// Default: "rows"
		/// </summary>
		// Token: 0x06015897 RID: 88215 RVA: 0x001E7157 File Offset: 0x001E5357
		public virtual void SetRowLabel(string _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetRowLabel_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06015898 RID: 88216
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetSubDiagonal_20(HandleRef pThis, double _arg);

		/// <summary>
		/// Stores the value that will be assigned to subdiagonal elements (default: 0)
		/// </summary>
		// Token: 0x06015899 RID: 88217 RVA: 0x001E7167 File Offset: 0x001E5367
		public virtual void SetSubDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetSubDiagonal_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601589A RID: 88218
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiagonalMatrixSource_SetSuperDiagonal_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Stores the value that will be assigned to superdiagonal elements (default: 0)
		/// </summary>
		// Token: 0x0601589B RID: 88219 RVA: 0x001E7177 File Offset: 0x001E5377
		public virtual void SetSuperDiagonal(double _arg)
		{
			vtkDiagonalMatrixSource.vtkDiagonalMatrixSource_SetSuperDiagonal_21(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001893 RID: 6291
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiagonalMatrixSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001894 RID: 6292
		public new static readonly string MRClassNameKey = "class vtkDiagonalMatrixSource";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000826 RID: 2086
		public enum StorageType
		{
			/// <summary>enum member</summary>
			// Token: 0x04001896 RID: 6294
			DENSE,
			/// <summary>enum member</summary>
			// Token: 0x04001897 RID: 6295
			SPARSE
		}
	}
}
